<Query Kind="Program">
  <NuGetReference>CompareNETObjects</NuGetReference>
  <Namespace>KellermanSoftware.CompareNetObjects</Namespace>
  <Namespace>System.Text.Json</Namespace>
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
		},
		new Store {
			Name = "Store 55",
			Address = new() { Address1="9999 Short Treacherous Road", Address2 = "", City="Phoenix", PostalCode="55321", State = states[3] },
		}
	};

	//original instance
	var originalConfig = new Configuration
	{
		Username = "Jeff",
		Password = "blueCheese",
		MaxUsers = 50,
		States = states,
		Stores = stores
	};

	originalConfig.Dump("originalConfig Instance");

	//serialize to JSON
	var jsonSerializerOptions = new JsonSerializerOptions
	{
		WriteIndented = true,
		//PropertyNamingPolicy = JsonNamingPolicy.CamelCase
	}; //optional, makes json pretty
	var configJson = System.Text.Json.JsonSerializer.Serialize(originalConfig, jsonSerializerOptions);
	configJson.Dump("JSON from originalConfig instance");

	//deserialize to new instance
	var deserializedJsonConfig = System.Text.Json.JsonSerializer.Deserialize<Configuration>(configJson);
	deserializedJsonConfig.Dump("deserializedConfig created from originalConfig JSON");

	//compare original and new (using the CompareNetObjects package)
	var comparer = new CompareLogic();
	comparer.Compare(originalConfig, deserializedJsonConfig).AreEqual.Dump("Deep Comparison Results");

}

public class Configuration
{

	public string Username { get; set; }

	public string Password { get; set; }

	public int MaxUsers { get; set; }

	public List<State> States { get; set; } = new List<State>();

	public List<Store> Stores { get; set; } = new List<Store>();
}

public class State
{
	public int Id { get; set; }
	public string Name { get; set; }
}

public class Store
{
	public string Name { get; set; }
	public Address Address { get; set; }
}

public class Address
{
	public string Address1 { get; set; }
	public string Address2 { get; set; }
	public string City { get; set; }
	public string PostalCode { get; set; }
	public State State { get; set; }
}
