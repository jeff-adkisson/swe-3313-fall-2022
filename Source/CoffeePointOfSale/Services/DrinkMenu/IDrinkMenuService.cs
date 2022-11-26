namespace CoffeePointOfSale.Services.DrinkMenu;

public interface IDrinkMenuService 
{
    Drinks Drinks { get; init; }
    void Write();
}