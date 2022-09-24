using CoffeePointOfSale.Forms.Base;

namespace CoffeePointOfSale.Services.FormFactory;

public class FormFactory
{
    private static IFormFactory? _provider;

    public static void SetProvider(IFormFactory provider)
    {
        if (_provider != null) throw new Exception("FormFactory provider is already set");
        _provider = provider;
    }

    public static FormBase Get<T>()
    {
        return _provider!.Create(typeof(T));
    }
}