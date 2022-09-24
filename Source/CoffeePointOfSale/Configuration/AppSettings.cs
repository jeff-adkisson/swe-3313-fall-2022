namespace CoffeePointOfSale.Configuration;

/// <summary>
/// Settings class. The data in [appsettings.json] is loaded here using the class structure's JSON equivalent
/// </summary>
public class AppSettings : IAppSettings
{
    public App App { get; init; } = new();

    public Tax Tax { get; init; } = new();

    public Rewards Rewards { get; init; } = new();
}