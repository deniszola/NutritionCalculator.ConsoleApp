using NutritionCalculator.ConsoleApp.Models;

namespace NutritionCalculator.ConsoleApp.Data;

internal static class SeedData
{
    public static readonly List<Food> Starches =
    [
        new Food("Potato", 98, 2.6, 0.1, 21, 550, 14, 1.1, 2.3),
        new Food("Sweet potato", 86, 1.6, 0.1, 20, 337, 55, 4.2, 3),
        new Food("Cassava", 159, 1.4, 0.3, 38, 271, 14, 1.7, 1.8),
        new Food("Yam", 118, 1.5, 0.2, 28, 816, 9, 0.5, 4.1),
        new Food("Oats", 356, 16, 8, 53, 350, 0, 0.9, 10),
        new Food("Corn", 86, 3.3, 1.4, 19, 270, 15, 6, 2),
        new Food("Popcorn", 288, 10, 9.8, 41, 274, 36, 0.9, 7.2),
        new Food("Wheat", 339, 14, 2.5, 71, 431, 2, 0.4, 12),
        new Food("Wheat bran", 220, 14, 5, 32, 1182, 0, 0.4, 32),
        new Food("Bulgur", 340, 10, 1.2, 72, 410, 0, 0.4, 8),
        new Food("Rice", 370, 8, 2.9, 77, 223, 7, 0.9, 3.5),
        new Food("White rice", 365, 7, 0.7, 80, 115, 5, 0.1, 1.3),
        new Food("Barley", 354, 12, 2.3, 73, 452, 12, 0.8, 17),
        new Food("Rye", 335, 10, 1.6, 75, 510, 2, 0.9, 15),
        new Food("Millet", 346, 11, 2.9, 72, 220, 5, 0.9, 8),
        new Food("Buckwheat", 343, 13, 3.4, 72, 460, 1, 0.8, 10),
        new Food("Sorghum", 339, 11, 3.3, 74, 350, 6, 0.6, 6.3),
        new Food("Quinoa", 368, 14, 6.1, 64, 563, 5, 0.9, 7),
        new Food("Bean", 347, 21, 1.2, 63, 1393, 12, 2.1, 16),
        new Food("Lentil", 353, 26, 1.1, 60, 955, 6, 2, 31),
        new Food("Pea", 341, 25, 1.2, 60, 981, 15, 8, 26),
        new Food("Chickpea", 364, 19, 6, 61, 875, 24, 11, 17),
        new Food("Soybean", 446, 36, 20, 30, 1797, 2, 7, 9),
    ];

    public static readonly List<Food> Vegetables =
    [
        new Food("Celery", 16, 0.7, 0.2, 3, 260, 80, 1.3, 1.6),
        new Food("Rhubarb", 21, 0.9, 0.2, 4.5, 288, 4, 1.1, 1.8),
        new Food("Tomato", 18, 0.9, 0.2, 3.9, 215, 5, 2.6, 1.2),
        new Food("Cucumber", 15, 0.7, 0.1, 3.6, 147, 2, 1.7, 0.5),
        new Food("Lettuce", 15, 1.4, 0.2, 2.9, 194, 28, 0.8, 1.3),
        new Food("Cabbage", 25, 1.3, 0.1, 6, 170, 18, 3.2, 2.5),
        new Food("Spinach", 23, 2.9, 0.4, 3.6, 558, 79, 0.4, 2.2),
        new Food("Cauliflower", 25, 1.9, 0.3, 5, 299, 30, 1.9, 2),
        new Food("Broccoli", 34, 2.8, 0.4, 7, 316, 33, 1.7, 2.6),
        new Food("Carrot", 41, 0.9, 0.2, 10, 320, 69, 4.7, 2.8),
        new Food("Beet", 43, 1.6, 0.2, 10, 325, 78, 7, 2.8),
        new Food("Jerusalem artichoke", 73, 2, 0, 17, 429, 4, 10, 1.6),
        new Food("Green bean", 31, 1.8, 0.2, 7, 211, 6, 3.3, 2.7),
        new Food("Yellow bean", 31, 1.8, 0.5, 7, 230, 6, 3.6, 3.4),
        new Food("Snow pea", 42, 3.3, 0.2, 7, 240, 4, 4, 2.8),
        new Food("Button mushroom", 22, 3.1, 0.3, 3.3, 318, 5, 2, 1),
        new Food("Shiitake mushroom", 34, 2.2, 0.5, 7, 304, 9, 2.4, 2.5),
        new Food("Chayote", 19, 0.8, 0.1, 4.5, 125, 2, 1.7, 1.7),
    ];

    public static readonly List<Food> Fruits =
    [
        new Food("Grape", 67, 0.6, 0.4, 17, 191, 2, 16, 0.9),
        new Food("Apple", 52, 0.3, 0.2, 14, 107, 1, 10, 2.4),
        new Food("Pear", 57, 0.4, 0.1, 15, 116, 1, 10, 3.1),
        new Food("Quince", 57, 0.4, 0.1, 15, 197, 4, 6, 1.9),
        new Food("Watermelon", 30, 0.6, 0.2, 8, 112, 1, 6, 0.4),
        new Food("Cantaloupe", 34, 0.8, 0.2, 8, 267, 16, 8, 0.9),
        new Food("Honeydew", 36, 0.5, 0.1, 9, 228, 18, 8, 0.8),
        new Food("Orange", 47, 0.9, 0.1, 12, 181, 1, 9, 2.4),
        new Food("Tangerine", 53, 0.8, 0.3, 13, 166, 2, 11, 1.8),
        new Food("Grapefruit", 42, 0.8, 0.1, 11, 135, 1, 7, 1.6),
        new Food("Lemon", 29, 1.1, 0.3, 9, 138, 2, 2.5, 2.8),
        new Food("Lime", 30, 0.7, 0.2, 11, 102, 2, 1.7, 2.8),
        new Food("Mango", 60, 0.8, 0.4, 15, 168, 1, 14, 1.6),
        new Food("Peach", 39, 0.9, 0.3, 10, 190, 1, 8, 1.5),
        new Food("Nectarine", 44, 1.1, 0.3, 11, 201, 1, 8, 1.7),
        new Food("Apricot", 48, 1.4, 0.4, 11, 259, 1, 9, 2),
        new Food("Plum", 46, 0.7, 0.3, 11, 157, 1, 10, 1.4),
        new Food("Cherry", 63, 1.1, 0.2, 16, 222, 1, 13, 2.1),
        new Food("Guava", 68, 2.6, 1, 14, 417, 2, 9, 5),
        new Food("Banana", 89, 1.1, 0.3, 23, 358, 1, 12, 2.6),
        new Food("Lychee", 66, 0.8, 0.4, 17, 171, 1, 15, 1.3),
        new Food("Kiwi", 61, 1.1, 0.5, 15, 312, 3, 9, 3),
        new Food("Fig", 74, 0.8, 0.3, 19, 232, 1, 16, 2.9),
        new Food("Passion fruit", 97, 2.2, 0.7, 23, 348, 28, 11, 10),
        new Food("Pineapple", 50, 0.5, 0.1, 13, 109, 1, 10, 1.4),
        new Food("Papaya", 43, 0.5, 0.3, 11, 257, 1, 8, 1.7),
        new Food("Persimmon", 127, 0.8, 0.4, 34, 310, 1, 14, 3.6),
        new Food("Strawberry", 32, 0.7, 0.3, 7, 153, 1, 4.9, 2),
        new Food("Raspberry", 53, 1.2, 0.7, 12, 151, 1, 4.4, 7),
        new Food("Blueberry", 57, 0.7, 0.3, 14, 77, 1, 10, 2.4),
        new Food("Blackberry", 43, 1.4, 0.5, 10, 162, 1, 4.9, 5),
        new Food("White currant", 56, 1.4, 0.2, 13, 200, 1, 8.5, 4.3),
        new Food("Blackcurrant", 63, 1.4, 0.4, 15, 330, 1, 8.4, 7.3),
        new Food("Redcurrant", 36, 1.1, 0.3, 4.4, 200, 1, 4.4, 3.4),
    ];

    public static readonly List<Food> Condiments =
    [
        new Food("Sugar", 387, 0, 0, 100, 2, 1, 100, 0),
        new Food("Cinnamon", 247, 4, 1.2, 81, 431, 10, 2.2, 53),
        new Food("Cocoa", 228, 20, 14, 58, 1524, 21, 1.8, 33),
    ];

    public static readonly List<Food> NutsAndSeeds =
    [
        new Food("Peanut", 585, 24, 50, 22, 658, 6, 4.2, 8),
        new Food("Chia", 304, 12, 20, 19, 407, 0, 0, 18),
    ];

    public static readonly List<Food> FakeMeatsAndCheeses =
    [
        new Food("Textured soy protein (TSP)", 282, 50, 0, 16, 0, 0, 0, 18),
        new Food("Vital wheat gluten", 396, 76, 4, 16, 100, 0, 0, 0),
    ];

    public static readonly List<Food> AnimalProducts =
    [
        new Food("Meat", 143, 26, 3.5, 0, 421, 57, 0, 0),
        new Food("Chicken", 239, 27, 14, 0, 223, 82, 0, 0),
        new Food("Egg", 155, 13, 11, 1.1, 126, 124, 1.1, 0),
    ];

    public static readonly List<Food> Fats =
    [
        new Food("Oil", 884, 0, 100, 0, 1, 2, 0, 0),
    ];
}
