using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.DrinkInOrder;

class DrinkInOrder
{
    private string Drink = "";
    private decimal BasePrice;
    private decimal Price;
    private string[] Customizations;

    public DrinkInOrder() { }
}
