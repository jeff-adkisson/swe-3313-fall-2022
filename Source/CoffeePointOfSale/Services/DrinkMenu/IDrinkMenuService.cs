namespace CoffeePointOfSale.Services.DrinkMenu;

public interface IDrinkMenuService 
{
    DrinkMenu DrinkMenu { get; init; }
    void Write();
}