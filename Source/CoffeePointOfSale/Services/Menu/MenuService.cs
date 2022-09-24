using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Services.Menu;

public class MenuService : IMenuService
{
    private readonly IStorageService _storageService;

    public MenuService(IStorageService storageService)
    {
        _storageService = storageService;
    }
}