using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu
{
    public class DrinkMenu
    {

        public List<Drink> Drinks { get; set; } = new List<Drink>();
        

        public void Add(Drink drink)
        {
            Drinks.Add(drink);
       
        }
    }
}
