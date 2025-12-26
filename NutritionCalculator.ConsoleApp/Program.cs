using NutritionCalculator.ConsoleApp.Config;
using NutritionCalculator.ConsoleApp.Data;
using System.Text.Json;

namespace NutritionCalculator.ConsoleApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine($"Instantiated {SeedData.Starches.Count} starches.");
        string fileName = "Starches.json";
        string starchesJson = JsonSerializer.Serialize(SeedData.Starches, Json.SerializerOptions);
        File.WriteAllText(fileName, starchesJson);
        Console.WriteLine(File.ReadAllText(fileName));

        Console.WriteLine($"Instantiated {SeedData.Vegetables.Count} vegetables.");
        fileName = "Vegetables.json";
        string vegetablesJson = JsonSerializer.Serialize(SeedData.Vegetables, Json.SerializerOptions);
        File.WriteAllText(fileName, vegetablesJson);
        Console.WriteLine(File.ReadAllText(fileName));

        Console.WriteLine($"Instantiated {SeedData.Fruits.Count} fruits.");
        fileName = "Fruits.json";
        string fruitsJson = JsonSerializer.Serialize(SeedData.Fruits, Json.SerializerOptions);
        File.WriteAllText(fileName, fruitsJson);
        Console.WriteLine(File.ReadAllText(fileName));

        Console.WriteLine($"Instantiated {SeedData.Condiments.Count} condiments.");
        fileName = "Condiments.json";
        string condimentsJson = JsonSerializer.Serialize(SeedData.Condiments, Json.SerializerOptions);
        File.WriteAllText(fileName, condimentsJson);
        Console.WriteLine(File.ReadAllText(fileName));

        Console.WriteLine($"Instantiated {SeedData.NutsAndSeeds.Count} nuts and seeds.");
        fileName = "NutsAndSeeds.json";
        string nutsAndSeedsJson = JsonSerializer.Serialize(SeedData.NutsAndSeeds, Json.SerializerOptions);
        File.WriteAllText(fileName, nutsAndSeedsJson);
        Console.WriteLine(File.ReadAllText(fileName));

        Console.WriteLine($"Instantiated {SeedData.FakeMeatsAndCheeses.Count} fake meats and cheeses.");
        fileName = "FakeMeatsAndCheeses.json";
        string fakeMeatsAndCheesesJson = JsonSerializer.Serialize(SeedData.FakeMeatsAndCheeses, Json.SerializerOptions);
        File.WriteAllText(fileName, fakeMeatsAndCheesesJson);
        Console.WriteLine(File.ReadAllText(fileName));

        Console.WriteLine($"Instantiated {SeedData.AnimalProducts.Count} animal products.");
        fileName = "AnimalProducts.json";
        string animalProductsJson = JsonSerializer.Serialize(SeedData.AnimalProducts, Json.SerializerOptions);
        File.WriteAllText(fileName, animalProductsJson);
        Console.WriteLine(File.ReadAllText(fileName));

        Console.WriteLine($"Instantiated {SeedData.Fats.Count} fats.");
        fileName = "Fats.json";
        string fatsJson = JsonSerializer.Serialize(SeedData.Fats, Json.SerializerOptions);
        File.WriteAllText(fileName, fatsJson);
        Console.WriteLine(File.ReadAllText(fileName));
    }
}
