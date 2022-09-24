namespace CoffeePointOfSale.Configuration;

public interface IAppSettings
{
    App App { get; init; }
    Tax Tax { get; init; }
    Rewards Rewards { get; init; }
}