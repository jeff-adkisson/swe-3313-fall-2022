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
        [JsonProperty("DrinkMenu")]
        private readonly Dictionary<string, Drink> _drinkDict = new();
        [JsonIgnore]
        public IReadOnlyList<Drink> List =>
            _drinkDict.Select(c => c.Value).ToList();

        public void Add(Drink drink)
        {
            _drinkDict.Add(drink.Name, drink);
       
        }
    }
}
