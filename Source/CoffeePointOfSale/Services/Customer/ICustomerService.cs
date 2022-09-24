namespace CoffeePointOfSale.Services.Customer;

public interface ICustomerService
{
    Customers Customers { get; init; }
    void Write();
}