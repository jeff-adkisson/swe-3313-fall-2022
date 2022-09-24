using CoffeePointOfSale.Forms;

namespace CoffeePointOfSale.Services.FormFactory;

public class FormFactory
{
    private static IFormFactory? _provider;

    public static void SetProvider(IFormFactory provider)
    {
        if (_provider != null) throw new Exception("FormFactory provider is already set");
        _provider = provider;
    }

    public static FormBase Get(Type formType)
    {
        return _provider!.Create(formType);
    }
}