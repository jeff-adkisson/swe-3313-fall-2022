using CoffeePointOfSale.Forms;

namespace CoffeePointOfSale.Services.FormFactory;

public interface IFormFactory
{
    FormBase Create(Type formType);
}