using System;
using System.Reflection;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Menu;
using CoffeePointOfSale.Services.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoffeePointOfSale;

internal static class Startup
{
    public static void ConfigureServices(IServiceCollection serviceCollection)
    {
        ConfigureDependencies(serviceCollection);
        SetupConfiguration(serviceCollection);
    }

    /// <summary>
    /// Call this after service provider is completely initialized
    /// </summary>
    /// <param name="serviceProvider"></param>
    public static void ConfigureFormFactory(IServiceProvider serviceProvider)
    {
        var formFactory = new FormFactoryProvider(serviceProvider);
        FormFactory.SetProvider(formFactory);
    }

    private static void ConfigureDependencies(IServiceCollection services)
    {
        services.AddSingleton<IStorageService, StorageService>();
        services.AddSingleton<ICustomerService, CustomerService>();
        services.AddSingleton<IDrinkMenuService, DrinkMenuService>();

        //add your dependencies here

        RegisterForms(services);
        services.AddLogging(configure => configure.AddConsole());
    }

    /// <summary>
    /// Automatically wires up all forms implementing FormBase to DI container
    /// </summary>
    /// <param name="services"></param>
    private static void RegisterForms(IServiceCollection services)
    {
        foreach (var formBaseType in 
                 Assembly.GetAssembly(typeof(FormBase))
                     ?.GetTypes()
                     .Where(myType => 
                         myType.IsClass && 
                         !myType.IsAbstract && 
                         myType.IsSubclassOf(typeof(FormBase)))!
                 )
        {
            services.AddTransient(formBaseType);
        }
    }

    private static void SetupConfiguration(IServiceCollection services)
    {
        var configBuilder = new ConfigurationBuilder()
            .AddJsonFile(
                "appsettings.json", 
                optional: false, 
                reloadOnChange: true);
        var config = configBuilder.Build();
        services.AddSingleton<IAppSettings, AppSettings>(_ => config.Get<AppSettings>());
    }
}