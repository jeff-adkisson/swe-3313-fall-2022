using Newtonsoft.Json;

namespace JsonToClassTypeBindingNewtonSoft;

public static class Program
{
    public static void Main()
    {
        var listOfPersons = new List<Person>
        {
            new User { Username = "Jeff", Name = "Jeff Adkisson", Email = "Jeff@KSU", Phone = "404-444-1234" },
            new User { Username = "Max", Name = "Max Adkisson", Email = "Max@Dog", Phone = "404-444-1234" },
            new Manager
            {
                Username = "Adam", Name = "Adam S.", Email = "Adam@HighMatch", Phone = "404-555-5432"
            },
            new Customer
            {
                CreditCard = "123-123-1234-44321", Name = "Poe Pickles", Email = "Poe@Pickles", Phone = "706-444-1234"
            },
            new Customer
            {
                CreditCard = "555-123-1234-44321", Name = "Chloe Adkisson", Email = "Chloe@Dog", Phone = "706-444-1234"
            },
            new Customer
            {
                CreditCard = "333-211-1234-44321", Name = "Girlie Adkisson", Email = "Girlie@Lizard",
                Phone = "776-444-1234"
            }
        };

        //without types
        var jsonWithoutType = JsonConvert.SerializeObject(listOfPersons, Formatting.Indented);
        var deserializedWithoutTypes = JsonConvert.DeserializeObject<List<Person>>(jsonWithoutType);
        ShowPersonList("JSON WITHOUT TYPES INCLUDED", jsonWithoutType, deserializedWithoutTypes);
        //without types

        var serializerWithTypesSetting = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        var jsonWithType = JsonConvert.SerializeObject(listOfPersons, Formatting.Indented, serializerWithTypesSetting);
        var deserializedWithTypes =
            JsonConvert.DeserializeObject<List<Person>>(jsonWithType, serializerWithTypesSetting);
        ShowPersonList("JSON ***WITH*** TYPES INCLUDED", jsonWithType, deserializedWithTypes);
    }

    private static void ShowPersonList(string label, string json, List<Person>? persons)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine(label);
        Console.WriteLine("==============================================");
        Console.WriteLine(json);
        Console.WriteLine("==============================================");
        Console.WriteLine($"List of {persons!.Count} Persons: ");
        Console.WriteLine("\r\n");
        for (var i = 0; i < persons.Count; i++)
        {
            var person = persons[i];
            Console.WriteLine($"{i} - Type is [{person.GetType().Name}]");
            Console.WriteLine(person);
            Console.WriteLine("\r\n\r\n");
        }

        //just the users (via LINQ)
        var allUsers = persons.Where(p => p is User).ToArray();
        Console.WriteLine($" - There are {allUsers.Count()} Users");
        var usersOnly = persons.Where(p => p is User and not Manager).ToArray();
        foreach (var userOnly in usersOnly) Console.WriteLine($"-> {userOnly.Name} is a User, but not a Manager");
        var managers = persons.Where(p => p is Manager).ToArray();
        Console.WriteLine(
            $" - There are {managers.Count()} Managers (Manager inherits from User, so a Manager is inherently a User)");
        foreach (var manager in managers)
            Console.WriteLine($"-> {manager.Name} is both a Manager and User via inheritance");
        var customers = persons.Where(p => p is Customer).Cast<Customer>().ToArray();
        Console.WriteLine($" - There are {customers.Count()} Customers");
        foreach (var customer in customers)
        {
            Console.WriteLine($"-> {customer.Name} is a customer");
            foreach (var user in allUsers)
                Console.WriteLine(
                    $"----- {user.Name} {(customer.CanSeeCreditCard(user) ? "is a Manager and CAN" : "is only a User and cannot")} see {customer.Name}'s credit card.");
        }
    }
}