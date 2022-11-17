<Query Kind="Program">
  <NuGetReference>CompareNETObjects</NuGetReference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>KellermanSoftware.CompareNetObjects</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>System.Text.Json</Namespace>
</Query>

//JSON C# example via LinqPad
void Main()
{
	//original instance
	var originalConfig = new Configuration { Username = "Jeff", Password = "blueCheese", MaxUsers = 50 };
	originalConfig.Dump("originalConfig Instance");
	
	//serialize to JSON

	var configJson = JsonConvert.SerializeObject(originalConfig, Newtonsoft.Json.Formatting.Indented);
	configJson.Dump("JSON from originalConfig instance");
	
	//deserialize to new instance
	var deserializedJsonConfig = JsonConvert.DeserializeObject<Configuration>(configJson);
	deserializedJsonConfig.Dump("deserializedConfig created from originalConfig JSON");
	
	//compare original and new (using the CompareNetObjects package)
	var comparer = new CompareLogic();
	comparer.Compare(originalConfig, deserializedJsonConfig).AreEqual.Dump("Deep Comparison Results");
	
}

public class Configuration {

	public string Username { get; set;}	
	
	public string Password { get; set; }
	
	public int MaxUsers { get; set; }
}
