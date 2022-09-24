namespace CoffeePointOfSale.Services.Storage;

public interface IStorageService
{
    T Read<T>() where T : new();
    
    void Write<T>(T value);
}