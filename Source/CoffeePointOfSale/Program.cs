using CoffeePointOfSale.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoffeePointOfSale;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        SetupDisplay();

        SetupDependencyInjection();

        Start();
    }

    private static void Start()
    {
        ApplicationConfiguration.Initialize();
        var mainForm = ServiceProvider!.GetRequiredService<FormMain>();
        Application.Run(mainForm);
    }

    private static void SetupDisplay()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
    }

    private static void SetupDependencyInjection()
    {
        //https://stackoverflow.com/a/70476716
        //how to setup DI for Winforms
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;
        Startup.ConfigureFormFactory(ServiceProvider);
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => Startup.ConfigureServices(services));
    }
}