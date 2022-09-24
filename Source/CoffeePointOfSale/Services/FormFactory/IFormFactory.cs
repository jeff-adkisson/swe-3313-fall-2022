using CoffeePointOfSale.Forms.Base;

namespace CoffeePointOfSale.Services.FormFactory;

public interface IFormFactory
{
    FormBase Create(Type formType);
}