namespace NutritionCalculator.ConsoleApp.Models;

internal class Food
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public double Protein { get; set; }
    public double Fat { get; set; }
    public double Carbohydrate { get; set; }
    public int Potassium { get; set; }
    public int Sodium { get; set; }
    public double Sugar { get; set; }
    public double Fibre { get; set; }

    public Food(string name,
                int calories,
                double protein,
                double fat,
                double carbohydrate,
                int potassium,
                int sodium,
                double sugar,
                double fibre)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Calories = calories;
        Protein = protein;
        Fat = fat;
        Carbohydrate = carbohydrate;
        Potassium = potassium;
        Sodium = sodium;
        Sugar = sugar;
        Fibre = fibre;
    }

    public override string? ToString()
    {
        return $"{Name}\n" +
               $" - Calories: {Calories} kcal\n" +
               $" - Protein: {Protein}g\n" +
               $" - Fat: {Fat}g\n" +
               $" - Carbohydrate: {Carbohydrate}g\n" +
               $" - Potassium: {Potassium}mg\n" +
               $" - Sodium: {Sodium}mg\n" +
               $" - Sugar: {Sugar}g\n" +
               $" - Fibre: {Fibre}g\n";
    }
}
