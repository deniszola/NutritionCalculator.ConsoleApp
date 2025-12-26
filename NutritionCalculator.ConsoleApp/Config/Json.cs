using System.Text.Json;

namespace NutritionCalculator.ConsoleApp.Config;

internal static class Json
{
    public static readonly JsonSerializerOptions SerializerOptions = new()
    {
        WriteIndented = true,
        IndentCharacter = ' ',
        IndentSize = 4
    };
}
