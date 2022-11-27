using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CoffeePointOfSale.Services.DrinkMenu;
namespace CoffeePointOfSale.Services.DrinkMenu;


[Serializable]
public class Drink
    {
    
        private string _Name;
        private string _BaseDescription;
        private decimal _BasePrice;
        private string _Image;
        public string Name { 
            get=> _Name;

            set {
                _Name = value;
            }  }
       public virtual string BaseDescription {
            get=>_BaseDescription;
            set {
                _BaseDescription = value;
            } }

        public virtual string Image { 
            get => _Image;
            set
            {
                _Image = value;
            } }
        public virtual decimal BasePrice { 
            get=> _BasePrice;
            set { 
                _BasePrice = value;
            }
            }
        public virtual List<Customization> Customizations { get; set; }
    }
    public class Customization
    {
        private string _Name;
        private decimal _Price;
        public string Name { get => _Name;
            set {
                _Name = value;
            } }
        public decimal Price { get=> _Price;
            set {
                _Price = value;
            } }

      
        public override string ToString()
        {
            return base.ToString();
        }
       
    }

