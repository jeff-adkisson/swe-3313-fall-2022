using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;
using System.Security.Cryptography.X509Certificates;

namespace CoffeePointOfSale.Services.Menu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        
        List<Drink> Drinks = _storageService.Read<List<Drink>>(nameof(DrinkMenu));

        DrinkMenu = new DrinkMenu.DrinkMenu()
        {
            Drinks = Drinks
        };
    }


        //your DrinkMenu.json to load on start will go in the JsonStorage directory
        public DrinkMenu.DrinkMenu DrinkMenu{ get; init; }
        public void Write() => _storageService.Write(nameof(DrinkMenu),DrinkMenu.Drinks);

}
