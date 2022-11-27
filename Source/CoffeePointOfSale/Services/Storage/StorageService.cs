using System.Reflection;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Storage;

public class StorageService : IStorageService
{
    private const string JsonDirectory = "JsonStorage";

    public T Read<T>(string name) where T : new()
    {
        var filename = GetFilename(name);
        CreateFileIfNotFound(filename);

        var jsonInFile = File.ReadAllText(filename);

        return JsonConvert.DeserializeObject<T>(jsonInFile)
               ?? throw new InvalidOperationException(
                   $"Could not deserialize JSON for {filename} to " +
                   $"type {typeof(T).FullName}");
    }

    public void Write<T>( string name, T instanceToSerialize)
    {
        if (instanceToSerialize == null)
            throw new ArgumentException("instanceToSerialize cannot be null", nameof(instanceToSerialize));
        var filename = GetFilename(name);
        var jsonToWrite = JsonConvert.SerializeObject(instanceToSerialize, Formatting.Indented);
            File.WriteAllText(filename, jsonToWrite);
    }

    private static void CreateFileIfNotFound(string filename)
    {
        if (File.Exists(filename)) return;
        File.WriteAllText(filename, "{}"); //writes an empty JSON file
    }

    private static string GetFilename(string name)
    {
        var filenameFromType = $"{name}.json";
        var binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var fullPath = Path.Combine(binPath ?? throw new InvalidOperationException("binPath is null"), JsonDirectory,
            filenameFromType);
        return fullPath;
    }
}