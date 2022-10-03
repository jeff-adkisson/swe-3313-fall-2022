<Query Kind="Program">
  <NuGetReference>CompareNETObjects</NuGetReference>
  <NuGetReference>CsvHelper</NuGetReference>
  <Namespace>KellermanSoftware.CompareNetObjects</Namespace>
  <Namespace>CsvHelper</Namespace>
  <Namespace>System.Globalization</Namespace>
</Query>

//CSV C# example via LinqPad
void Main()
{
	//original instance
	var originalConfig = new Configuration { Username = "Jeff", Password = "blueCheese", MaxUsers = 50 };
	GenerateAndTestCsv(originalConfig);
	
	Console.WriteLine("============ NASTY PARSING EXAMPLE ===========");
	
	var awfulPasswordForCsv = "blueCheese,\"YUM,YUM\",really?";
	awfulPasswordForCsv.Dump("Password contains lots of commas");
	awfulPasswordForCsv.Split(",").Dump("Split Password on Comma");
	var disaster = new Configuration { Username = "Adkisson,Jeff", Password = awfulPasswordForCsv, MaxUsers = 50 };
	GenerateAndTestCsv(disaster);
	

}

void GenerateAndTestCsv(Configuration configuration)
{
	//original instance
	configuration.Dump("configuration Instance");

	//write (serialize) to CSV
	string csvOutput;
	using (var writer = new StringWriter())
	using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
	{
		csvWriter.WriteRecords(new List<Configuration> { configuration });
		csvOutput = writer.ToString().Dump("CSV from configuration");
	}

	//read into new config instance
	Configuration configurationFromCsv;
	using (var reader = new System.IO.StringReader(csvOutput))
	using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
	{
		configurationFromCsv = csvReader.GetRecords<Configuration>().ToArray()[0];
	}
	configurationFromCsv.Dump("configurationFromCsv created from configuration CSV");

	//compare original and new (using the CompareNetObjects package)
	var comparer = new CompareLogic();
	comparer.Compare(configuration, configurationFromCsv).AreEqual.Dump("Deep Comparison Results");
}

public class Configuration
{

	public string Username { get; set; }

	public string Password { get; set; }

	public int MaxUsers { get; set; }
}
