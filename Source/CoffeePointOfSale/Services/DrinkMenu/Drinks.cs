using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft;
using System.IO;


namespace CoffeePointOfSale.Services.DrinkMenu
{
    
    internal class Drinks
    {
       static void Main(string[] args)
        {
            var drink = File.ReadAllText(@"C:\Users\omowu\Source\Repos\swe\Source\CoffeePointOfSale\JsonStorage\DrinkMenu.json");
            var myDrink = JsonConvert.DeserializeObject<Drinks>(drink);
        }
    }
}
