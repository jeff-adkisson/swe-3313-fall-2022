using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkInOrder__Customizations;

class Drink
{
    private string name;
    private string baseDescription;
    private decimal basePrice;
    private decimal totalPrice;

    public Drink(string n, string bd, decimal b) 
    {
        name= n;
        baseDescription= bd;
        basePrice= b;
    }

    public void AddCustomization(string n, int q, decimal p)
    {
        Customization c = new Customization(n, q, p);
        totalPrice = basePrice + (p * q);
    }

    public string GetName() { return name; }
}
