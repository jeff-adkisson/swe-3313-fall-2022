<Query Kind="Program">
  <NuGetReference>CsvHelper</NuGetReference>
  <Namespace>CsvHelper</Namespace>
  <Namespace>System.Text.Json</Namespace>
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	var rand = new Random();
	var transactions = new List<Transaction>();
	
	var drinks = new List<Drink>() {
		new Drink(
			"Latte",
			4.00m,
			new() {
				new Customization("Small", -1.00m),
				new Customization("Extra Hot", 0.00m),
				new Customization("Oat Milk", 0.75m)
			}
		),
		new Drink(
			"Matcha Green Tea Latte",
			5.00m,
			new() {
				new Customization("Large", 1.00m),
				new Customization("Iced", 0.00m),
				new Customization("Non Fat Milk", 0.00m)
			}
		)
	};
	transactions.Add(new Transaction("404-123-1234", false, 0.06m, drinks));

	drinks = new List<Drink>() {
		new Drink(
			"Coffee",
			2.00m
		)
	};
	transactions.Add(new Transaction("404-123-1234", true, 0.06m, drinks));

	drinks = new List<Drink>() {
		new Drink(
			"Water",
			0.00m
		),
		new Drink(
			"Matcha Green Tea Latte",
			5.00m,
			new() {
				new Customization("Small", -1.00m)
			}
		)
	};
	transactions.Add(new Transaction("706-777-1234", true, 0.06m, drinks));

	drinks = new List<Drink>() {
		new Drink(
			"Water",
			0.00m
		),
		new Drink(
			"Coffee",
			2.00m,
			new() {
				new Customization("Large", 1.00m),
				new Customization("Room for Cream", 0.00m)
			}
		)
	};
	transactions.Add(new Transaction("706-777-1234", false, 0.06m, drinks));

	transactions.Dump();

	using( var stream = new MemoryStream() )
	using( var reader = new StreamReader( stream ) )
	using( var writer = new StreamWriter( stream ) )
	using( var csv = new CsvHelper.CsvWriter( writer, CultureInfo.InvariantCulture ) )
	{
	    csv.WriteRecords( transactions.OrderBy(t => t.TransactionDateTime));
	    writer.Flush();
		stream.Position = 0;
		var text = reader.ReadToEnd();
		text.Dump();
		var path = Path.Join(Path.GetTempPath(), "sales_data.csv");
		File.WriteAllText(path, text);
		path.Dump();
	}
}

public class Transaction
{

	public Transaction(string customerId, bool isCreditCard, decimal taxRate, List<Drink> drinks, int rewardsPerDollar = 10)
	{
		CustomerId = customerId;
		TransactionDateTime = DateTime.Now.AddMinutes(new Random().Next(-10000, -10));
		Payment = isCreditCard ? "Credit Card" : "Rewards";
		Subtotal = drinks.Sum(d => d.BasePrice + d.Customizations.Sum(c => c.Price));
		Tax = Math.Round(Subtotal * taxRate, 2);
		Total = Math.Round(Subtotal + Tax, 2);
		OrderDescription = string.Join(" | ", drinks);
		RewardsPointsRedeemed = isCreditCard ? 0 : (int)Math.Ceiling(Total * rewardsPerDollar);
		Drinks = drinks;
	}

	public List<Drink> Drinks { get; }
	public string CustomerId { get; }
	public DateTime TransactionDateTime { get; }
	public decimal Subtotal { get; }
	public decimal Tax { get; }
	public decimal Total { get; }
	public string Payment { get; }
	public int RewardsPointsRedeemed { get; }
	public string OrderDescription { get; }
}

public class Drink
{
	public Drink(string name, decimal basePrice, List<Customization>? customizations = null)
	{
		Name = name;
		BasePrice = basePrice;
		Customizations = customizations ?? new();
	}
	public string? Name { get; set; }
	public decimal BasePrice { get; }
	public List<Customization> Customizations { get; }
	public decimal Price => Math.Round(BasePrice + Customizations.Sum(c => c.Price), 2);

	public override string ToString()
	{
		return $"{Price:C2} {Name} {string.Join(',', Customizations.Select(c => c.Name))}".Trim();
	}
}

public class Customization {
	public Customization(string name, decimal price)
	{
		Name = name;
		Price = price;
	}
	
	public string Name { get; }
	public decimal Price { get; }
}