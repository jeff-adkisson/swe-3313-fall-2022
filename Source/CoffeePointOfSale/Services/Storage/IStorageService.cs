namespace CoffeePointOfSale.Services.Storage;

public interface IStorageService
{
    T Read<T>(string name) where T : new();
    
    void Write<T>(string name, T value);
}