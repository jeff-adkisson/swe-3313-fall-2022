using CoffeePointOfSale.Forms.Base;

namespace CoffeePointOfSale.Services.FormFactory;

public class FormFactoryProvider : IFormFactory
{
    private readonly IServiceProvider _serviceProvider;

    public FormFactoryProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public FormBase Create(Type formType)
    {
        return _serviceProvider.GetService(formType) as FormBase
               ?? throw new Exception($"Type {formType} not registered as a FormBase type");
    }
}