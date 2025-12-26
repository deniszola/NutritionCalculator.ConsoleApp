using NutritionCalculator.ConsoleApp.Data;

namespace NutritionCalculator.ConsoleApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine($"Instantiated {SeedData.Starches.Count} starches.");
        Console.WriteLine($"Instantiated {SeedData.Vegetables.Count} vegetables.");
        Console.WriteLine($"Instantiated {SeedData.Fruits.Count} fruits.");
        Console.WriteLine($"Instantiated {SeedData.Condiments.Count} condiments.");
        Console.WriteLine($"Instantiated {SeedData.NutsAndSeeds.Count} nuts and seeds.");
        Console.WriteLine($"Instantiated {SeedData.FakeMeatsAndCheeses.Count} fake meats and cheeses.");
        Console.WriteLine($"Instantiated {SeedData.AnimalProducts.Count} animal products.");
        Console.WriteLine($"Instantiated {SeedData.Fats.Count} fats.");
    }
}
