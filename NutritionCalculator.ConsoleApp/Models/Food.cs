namespace NutritionCalculator.ConsoleApp.Models;

internal record Food(string Name,
                     int Calories,
                     double Protein,
                     double Fat,
                     double Carbohydrate,
                     int Potassium,
                     int Sodium,
                     double Sugar,
                     double Fibre);
