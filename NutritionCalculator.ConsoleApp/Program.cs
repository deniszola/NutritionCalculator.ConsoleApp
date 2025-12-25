using NutritionCalculator.ConsoleApp.Data;
using NutritionCalculator.ConsoleApp.Models;

namespace NutritionCalculator.ConsoleApp;

internal class Program
{
    static void Main()
    {
        Dictionary<string, Food> starches = SeedData.Starches;
        Dictionary<string, Food> vegetables = SeedData.Vegetables;
        Dictionary<string, Food> fruits = SeedData.Fruits;
        Dictionary<string, Food> condiments = SeedData.Condiments;
        Dictionary<string, Food> nutsAndSeeds = SeedData.NutsAndSeeds;
        Dictionary<string, Food> fakeMeatsAndCheeses = SeedData.FakeMeatsAndCheeses;
        Dictionary<string, Food> animalProducts = SeedData.AnimalProducts;
        Dictionary<string, Food> fats = SeedData.Fats;

        Console.WriteLine($"Instantiated {starches.Count} starches.");
        Console.WriteLine($"Instantiated {vegetables.Count} vegetables.");
        Console.WriteLine($"Instantiated {fruits.Count} fruits.");
        Console.WriteLine($"Instantiated {condiments.Count} condiments.");
        Console.WriteLine($"Instantiated {nutsAndSeeds.Count} nuts and seeds.");
        Console.WriteLine($"Instantiated {fakeMeatsAndCheeses.Count} fake meats and cheeses.");
        Console.WriteLine($"Instantiated {animalProducts.Count} animal products.");
        Console.WriteLine($"Instantiated {fats.Count} fats.");
    }
}
