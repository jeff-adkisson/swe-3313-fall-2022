<Query Kind="Program">
  <NuGetReference>CompareNETObjects</NuGetReference>
  <Namespace>KellermanSoftware.CompareNetObjects</Namespace>
  <Namespace>System.Text.Json</Namespace>
  <Namespace>System.Text.Json.Serialization</Namespace>
</Query>

//JSON C# example via LinqPad
void Main()
{
	var states = new List<State> {
			new State { Id = 1, Name = "Alabama" },
			new State { Id = 2, Name = "Alaska" },
			new State { Id = 3, Name = "American Samoa" },
			new State { Id = 4, Name = "Arizona" },
			new State { Id = 5, Name = "Arkansas" }
	};
	
	var stores = new List<Store> {
		new Store {
			Name = "Store 17",
			Address = new() { Address1="1515 Long Straight Road", Address2 = "Suite 300", City="Birmingham", PostalCode="55555", State = states[0] },
			ContactInformation = new () { Phone = "555-444-3333", Email = "Store17@StoresInAStates.com" },
			Manager = new Person { 
				NameFirst = "Patrick", NameLast = "Star",
				Address = new() { Address1 = "Under Rock", Address2 = "", City = "Bikini Bottom", PostalCode = "27152", State = states[0]},
				ContactInformation = new() { Email = "Store17Manager@StoresInAStates.com", Phone = "555-432-8989"}
			}
		},
		new Store {
			Name = "Store 55",
			Address = new() { Address1="9999 Short Treacherous Road", Address2 = "", City="Phoenix", PostalCode="55321", State = states[3] },
			ContactInformation = new () { Phone = "777-876-5555", Email = "Store55@StoresInAStates.com" },
			Manager = new Person {
				NameFirst = "Bender", NameLast = "Rodriguez",
				Address = new() { Address1 = "Planet Express", Address2 = "", City = "New New York", PostalCode = "76761", State = states[2]},
				ContactInformation = new() { Email = "Bender@StoresInAStates.com", Phone = ""}
			}
		}
	};
		
	//original instance
	var originalConfig = new Configuration { 
		Username = "Jeff", 
		Password = "blueCheese", 
		MaxUsers = 50,
		States = states,
		Stores = stores
	};
	
	//add a customer to store 17
	var newCust = new Customer { 
		NameFirst = "Jeff", 
		NameLast = "Adkisson",
		ContactInformation = new() { Email = "Jeff@Customer.com", Phone="404-444-1234" },
		Address = new() { Address1 = "555 Murder Bear Trail", Address2 = "", City = "Juneau", PostalCode="55123", State = states[1]}
	};
	stores[0].Customers.Add(newCust);
	
	//add two orders to customer from store 17
	newCust.Orders.Add(new() { Purchased = "Candy Lovers Pizza", TotalCost = 15.55m });
	newCust.Orders.Add(new() { Purchased = "Fingernails and Hair Pizza", TotalCost = 27.32m });

	//add a customer to store 55
	newCust = new Customer
	{
		NameFirst = "Poe",
		NameLast = "Pickles",
		ContactInformation = new() { Email = "Poe@Customer.com", Phone = "706-444-1234" },
		Address = new() { Address1 = "999 Squishy Bug Lane", Address2 = "", City = "Bentonville", PostalCode = "33123", State = states[4] }
	};
	stores[1].Customers.Add(newCust);

	//add 4 orders to customer from store 5
	newCust.Orders.Add(new() { Purchased = "Extra Large Bug Lovers Pizza", TotalCost = 25.55m, TipAmount = 5m });
	newCust.Orders.Add(new() { Purchased = "Extra Large Bug Lovers Pizza", TotalCost = 25.55m, TipAmount = 5m });
	newCust.Orders.Add(new() { Purchased = "Extra Large Bug Lovers Pizza", TotalCost = 25.55m, TipAmount = 5m });
	newCust.Orders.Add(new() { Purchased = "Extra Large Bug Lovers Pizza", TotalCost = 25.55m, TipAmount = 10m });

	originalConfig.Dump("originalConfig Instance");
	
	//serialize to JSON with camelCase
	var jsonSerializerOptions = new JsonSerializerOptions { 
		WriteIndented = true,
		PropertyNamingPolicy = JsonNamingPolicy.CamelCase
	}; 
	var configJson = System.Text.Json.JsonSerializer.Serialize(originalConfig, jsonSerializerOptions);
	configJson.Dump("JSON from originalConfig instance");

	//deserialize to new instance from camelCase back to PascalCase
	var deserializedJsonConfig = System.Text.Json.JsonSerializer.Deserialize<Configuration>(configJson);
	deserializedJsonConfig.Dump("deserializedConfig created from originalConfig JSON");
	
	//compare original and new (using the CompareNetObjects package)
	var comparer = new CompareLogic();
	comparer.Compare(originalConfig, deserializedJsonConfig).AreEqual.Dump("Deep Comparison Results");

	//find all customers who bad tippers using loops
	var badTippers = new List<Person>();
	foreach (var store in deserializedJsonConfig.Stores)
	{
		foreach (var customer in store.Customers)
		{
			foreach (var order in customer.Orders)
			{
				if (order.TipAmount < order.TotalCost * 0.15m)
				{
					badTippers.Add(customer);
					break;
				}
			}
		}
	}
	badTippers.Dump("Bad tippers");

	//find all customers who bad tippers via Linq
	var badTippersLinq = deserializedJsonConfig
		.Stores
		.SelectMany(o => o.Customers)
		.Where(customer => customer.Orders.Any(order => order.TipAmount < order.TotalCost * 0.15m))
		.ToList();
	badTippersLinq.Dump("Bad tipper via LINQ query");
}

public class Configuration {

	[JsonPropertyName("username")]
	public string Username { get; set;}	
	
	[JsonPropertyName("password")]
	public string Password { get; set; }
	
	[JsonPropertyName("maxUsers")]
	public int MaxUsers { get; set; }
	
	[JsonPropertyName("states")]
	public List<State> States { get; set; } = new List<State>();
	
	[JsonPropertyName("stores")]
	public List<Store> Stores { get; set; } = new List<Store>();
}

public class State {
	[JsonPropertyName("id")]
	public int Id { get; set; }
	
	[JsonPropertyName("name")]
	public string Name { get; set; }
}

public class Store {
 	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[JsonPropertyName("contactInformation")]
	public ContactInformation ContactInformation { get; set;}
	
	[JsonPropertyName("address")]
	public Address Address { get; set; }
	
	[JsonPropertyName("manager")]
	public Person Manager { get; set; }
	
	[JsonPropertyName("customers")]
	public List<Customer> Customers { get; set;} = new();
}

public class ContactInformation {
	[JsonPropertyName("email")]
	public string Email { get; set; }
	
	[JsonPropertyName("phone")]
	public string Phone { get; set; }
}

public class Customer : Person {
	[JsonPropertyName("orders")]
	public List<Order> Orders { get; set; } = new ();
}

public class Order { 
	[JsonPropertyName("purchased")]
	public string Purchased { get; set; }
	
	[JsonPropertyName("totalCost")]
	public decimal TotalCost { get; set; }
	
	[JsonPropertyName("tipAmount")]
	public Decimal TipAmount { get; set; }
	
	//this would have lots more data in a real implementation
}

public class Person {
	[JsonPropertyName("nameFirst")]
	public string NameFirst { get; set;}	
	
	[JsonPropertyName("nameLast")]
	public string NameLast { get; set; }
	
	[JsonPropertyName("address")]
	public Address Address { get; set; }
	
	[JsonPropertyName("contactInformation")]
	public ContactInformation ContactInformation { get; set; }
}

public class Address {
	[JsonPropertyName("address1")]
	public string Address1 { get; set; }
	
	[JsonPropertyName("address2")]
	public string Address2 { get; set; }
	
	[JsonPropertyName("city")]
	public string City { get; set; }
	
	[JsonPropertyName("postalCode")]
	public string PostalCode { get; set;}
	
	[JsonPropertyName("state")]
	public State State { get; set;}
}
