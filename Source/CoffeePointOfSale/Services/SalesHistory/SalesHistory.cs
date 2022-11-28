using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.SalesHistory;

class SalesHistory
{
    [JsonProperty("SalesHistory")]
    private readonly Dictionary<string, SalesHistory> _salesDict = new();


    public string DateTime = "";
    public Decimal Tax;
    public Decimal Subtotal;
    public Decimal Total;
    public int PointsEarned;
    public string Payment = "";
    public string PaymentDetails = "";

    //List<Drink> drinksInOrder = new List<Drink>();

    //Needs to send info to CSV Formatter
}
