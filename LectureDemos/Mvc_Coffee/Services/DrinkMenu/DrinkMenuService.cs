using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Mvc_Coffee.Models.DrinkMenu;
using Newtonsoft.Json;

namespace Mvc_Coffee.Services.DrinkMenu;

public class DrinkMenuService : IDrinkMenuService
{
    public DrinkMenuService()
    {
        var drinkMenuList = LoadDrinkMenuFromJsonFile();
        var sortedDrinkMenuList = SortDrinkMenuList(drinkMenuList);
        Drinks = sortedDrinkMenuList.AsReadOnly();
    }

    private static List<DrinkModel> SortDrinkMenuList(List<DrinkModel> drinkMenuList)
    {
        //sort the drink menu with linq (language integrated query)
        var sortedDrinkMenuList = drinkMenuList.OrderBy(drink => drink.Name).ThenBy(drink => drink.BasePrice).ToList();

        //sort each list of customizations
        foreach (var drink in sortedDrinkMenuList)
            drink.Customizations = drink.Customizations.OrderBy(customization => customization.Name)
                .ThenBy(customization => customization.Price).ToList();

        return sortedDrinkMenuList;
    }

    private static List<DrinkModel> LoadDrinkMenuFromJsonFile()
    {
        //load the drink list from the Data/DrinkMenu.json file
        var execDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var jsonPath = Path.Combine(execDir ?? throw new InvalidOperationException(),
            "Services",
            "DrinkMenu",
            "Data",
            "DrinkMenu.json");
        var json = File.ReadAllText(jsonPath);
        var drinkMenuList = JsonConvert.DeserializeObject<List<DrinkModel>>(json);
        if (drinkMenuList == null || !drinkMenuList.Any())
            throw new Exception($"Drink Menu JSON not found or empty at {jsonPath}");

        return drinkMenuList;
    }

    public IReadOnlyList<DrinkModel> Drinks { get; init; }
}