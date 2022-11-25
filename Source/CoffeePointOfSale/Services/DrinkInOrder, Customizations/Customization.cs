using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkInOrder__Customizations;

class Customization
{
    private string name;
    private int quantity;
    private decimal price;

    public Customization(string n, int q, decimal p) 
    {
        name = n;
        quantity = q;
        price = p * q;
    }
}
