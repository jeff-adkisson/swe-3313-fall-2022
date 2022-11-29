using System.Diagnostics;
using System.Globalization;
using CsvHelper;

namespace csv_write_open_demo;

public class Program
{
    private static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer
            {
                CustomerId = "404-444-1234",
                Name = "Customer 1",
                Orders = new List<Order>()
                {
                    new Order()
                    {
                        OrderId = Guid.NewGuid().ToString(),
                        TransactionDate = DateTime.Now,
                        TotalPrice = 15.75m,
                        Drinks = new List<Drink>()
                        {
                            new Drink()
                            {
                                Name = "Latte",
                                BasePrice = 4.50m,
                                Customizations = new List<string>() { "Extra Hot", "Super Big " }
                            },
                            new Drink()
                            {
                                Name = "Water",
                                BasePrice = 0m,
                                Customizations = new List<string>()
                            }
                        }
                    }
                }
            },
            new Customer
            {
                CustomerId = "555-555-9876",
                Name = "Customer 2",
                Orders = new List<Order>()
                {
                    new Order()
                    {
                        OrderId = Guid.NewGuid().ToString(),
                        TransactionDate = DateTime.Now,
                        TotalPrice = 5.75m,
                        Drinks = new List<Drink>()
                        {
                            new Drink()
                            {
                                Name = "Matcha",
                                BasePrice = 5.75m,
                                Customizations = new List<string>() { "Cold", "Oat Milk" }
                            }
                        }
                    },
                    new Order()
                    {
                        OrderId = Guid.NewGuid().ToString(),
                        TransactionDate = DateTime.Now.AddDays(-1),
                        TotalPrice = 9.75m,
                        Drinks = new List<Drink>()
                        {
                            new Drink()
                            {
                                Name = "Matcha",
                                BasePrice = 5.75m,
                                Customizations = new List<string>() { "Cold", "Oat Milk" }
                            },
                            new Drink()
                            {
                                Name = "Latte",
                                BasePrice = 4.00m,
                                Customizations = new List<string>()
                            },
                        }
                    },
                    new Order()
                    {
                        OrderId = Guid.NewGuid().ToString(),
                        TransactionDate = DateTime.Now.AddDays(-2),
                        TotalPrice = 3.00m,
                        Drinks = new List<Drink>()
                        {
                            new Drink()
                            {
                                Name = "Coffee",
                                BasePrice = 3.00m,
                                Customizations = new List<string>() { "Room for Cream" }
                            }
                        }
                    }
                }
            },
        };

        var csvExtractLines = new List<CsvExtractLine>(); //contains CSV extract data
        
        //loop through each customer and each order - output will have N customers * M orders lines
        //for example, 5 customers each with 5 orders will produce 25 lines of output
        foreach (var customer in customers)
        {
            foreach (var order in customer.Orders)
            {
                var csvExtractLine = new CsvExtractLine
                {
                    CustomerId = customer.CustomerId,
                    CustomerName = customer.Name,
                    OrderDate = order.TransactionDate,
                    OrderId = order.OrderId,
                    OrderTotalPrice = order.TotalPrice,
                    OrderDetails = order.ToString()
                };

                csvExtractLines.Add(csvExtractLine);
            }
        }

        //set path and filename
        var outputDirectory = Path.GetTempPath(); //find OS temp directory
        var csvFilename = $"output_{DateTime.Now.Ticks}.csv";
        var csvPathAndFilename = Path.Join(outputDirectory, csvFilename);

        //write csvExtractLines via CSVHelper
        using (var writer = new StreamWriter(csvPathAndFilename))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(csvExtractLines);
        }

        //attempt to open in Excel (or whatever is registered to open .csv files on the machine)
        try
        {
            var processStartInfo = new ProcessStartInfo(csvPathAndFilename)
            {
                WorkingDirectory = outputDirectory,
                UseShellExecute = true
            };
            Process.Start(processStartInfo);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open [{csvPathAndFilename}]: {ex.Message}");
        }
    }

    public class CsvExtractLine
    {
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotalPrice { get; set; }
        public string? OrderDetails { get; set; }
    }

    public class Customer
    {
        public string? CustomerId { get; set; }
        public string? Name { get; set; }
        public List<Order> Orders { get; set; } = new();
    }

    public class Order
    {
        public string? OrderId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Drink> Drinks { get; set; } = new();

        public override string ToString()
        {
            //join all of the drinks together using the Drink ToString method
            return string.Join(" | ", Drinks);
        }
    }

    public class Drink
    {
        public string? Name { get; set; }
        public decimal BasePrice { get; set; }
        public List<string> Customizations { get; set; } = new();

        public override string ToString()
        {
            var drink = $"{Name} {BasePrice:C}";
            if (Customizations.Count > 0)
            {
                drink += " " + string.Join(", ", Customizations);
            }

            return drink;
        }
    }
}