using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CoffeePointOfSale.Services.DrinkMenu;
namespace CoffeePointOfSale.Services.DrinkMenu
{
    [Serializable]
    
    public class Drink
    {
       public string Name { get; set; }
       public string BaseDescription { get; set; }
        public string Image { get; set; }
        public decimal BasePrice { get; set; }
        public List<Customization> Customizations { get; set; }

       
    }
    public class Customization
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
