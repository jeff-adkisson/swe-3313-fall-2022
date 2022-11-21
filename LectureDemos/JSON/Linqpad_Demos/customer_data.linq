<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>System.Text.Json</Namespace>
</Query>

void Main()
{
	var json = GetCustomerJson();
	json.Dump("JSON");
	var customers = JsonConvert.DeserializeObject<Customers>(json);
	customers!.List.Dump("All Customers and Orders");
	customers["404-444-5555"].Dump("404-444-5555");

	var lookupNumber = "777-123-1234";
	var customer = customers[lookupNumber];
	if (customer == null)
	{
		lookupNumber.Dump($"{lookupNumber} DOES NOT EXIST");
	}
}

string GetCustomerJson()
{
	return @"{
  ""Customers"": {
    ""anonymous"": {
      ""Phone"": ""anonymous"",
      ""RewardPoints"": 0, 
	  ""Orders"": [
	  	{
			""TransactionDate"": ""10/21/2022 7:00 AM"",
		  	""TotalPrice"": 15.00,
			""OrderItems"": [
				{  ""Product"": ""Latte"",
				   ""Price"": 5.00,
				   ""Customizations"": ""Small, Extra Hot, Extra Beef""
				},
				{  ""Product"": ""Water"",
				   ""Price"": 0.00,
				   ""Customizations"": """"
				},
				{  ""Product"": ""Frappe"",
				   ""Price"": 10.00,
				   ""Customizations"": ""Gigantic, Nectar, Panda Milk, Parisian Ice""
				}
			]
		},
		{
			""TransactionDate"": ""10/22/2022 8:00 AM"",
		  	""TotalPrice"": 4.00,
			""OrderItems"": [
				{  ""Product"": ""Latte"",
				   ""Price"": 4.00,
				   ""Customizations"": ""Small""
				}
			]
		}
	  ]
    },
    ""404-444-5555"": {
      ""Phone"": ""404-444-5555"",
      ""RewardPoints"": 95,
	  ""Orders"": [
	  	{
			""TransactionDate"": ""10/21/2022 7:00 AM"",
		  	""TotalPrice"": 9.00,
			""OrderItems"": [
				{  ""Product"": ""Green Tea"",
				   ""Price"": 5.00,
				   ""Customizations"": ""Small, Ghost Peppers""
				},
				{  ""Product"": ""Beans and Cheese Latte"",
				   ""Price"": 4.00,
				   ""Customizations"": ""Add Hot Dog, Extra Cheese""
				}
			]
		}
	  ]
    }
  }
}";
}

public class Order
{
	public DateTime TransactionDate { get; set; }
	public decimal TotalPrice { get; set; }
	public List<OrderItem> OrderItems { get; set; }
}

public class OrderItem {
	public string Product { get; set; }
	public decimal Price { get; set;}
	public string Customizations { get; set;}
}

public class Customer
{
	public const string AnonymousCustomerId = "anonymous";


	private string _phone = ""; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
	private int _rewardPoints;

	public virtual string Phone
	{
		get => _phone;
		set
		{
			if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone cannot be empty or null");
			_phone = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
		}
	}

	public virtual int RewardPoints

	{
		get => _rewardPoints;
		set
		{
			if (IsAnonymous) return; //you cannot set reward points for the anonymous customer record
			_rewardPoints = value;
		}
	}
	
	public List<Order> Orders { get; set; } = new();

	[JsonIgnore]
	public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

	public override string ToString()
	{
		return IsAnonymous
			? "Anonymous Customer - No Reward Points"
			: $"{Phone}, Reward Points: {RewardPoints}";
	}
}

public class Customers
{
	/// <summary>
	/// Private dictionary containing all of the customers. Lookup via phone.
	/// </summary>
	[JsonProperty("Customers")]
	private readonly Dictionary<string, Customer> _customerDict = new();

	/// <summary>
	/// Returns a readonly list of all customers.
	/// </summary>
	[JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
	public IReadOnlyList<Customer> List =>
		_customerDict.Select(c => c.Value)
			.OrderBy(c => c.IsAnonymous ? 0 : 1)
			.ToList();

	/// <summary>
	/// Indexer to return a specific customer by phone.
	/// </summary>
	/// <param name="phone"></param>
	/// <returns>Returns a customer if phone was found. Returns null otherwise. Does not throw.</returns>
	public Customer? this[string phone]
	{
		get
		{
			phone = (phone ?? "").Trim(); //ensures phone is not null and has no leading or trailing spaces
			return _customerDict.ContainsKey(phone) ? _customerDict[phone] : null;
		}
	}

	/// <summary>
	/// Adds a new customer to the customer dictionary.
	/// </summary>
	/// <param name="customer"></param>
	/// <returns>True if added. False if not added (phone already present in list). Does not throw.</returns>
	public bool Add(Customer customer)
	{
		if (this[customer.Phone] != null) return false;
		_customerDict.Add(customer.Phone, customer);
		return true;
	}
}