using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Services.Menu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;

        

}