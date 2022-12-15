// See https://aka.ms/new-console-template for more information
MealBuilder mealBuilder = new MealBuilder();

Meal vegMeal = mealBuilder.prepareVegMeal();
Console.WriteLine("Veg Meal");
vegMeal.ShowItems();
Console.WriteLine("Total Cost: " + vegMeal.GetCost());

Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
Console.WriteLine("\n\nNon-Veg Meal");
nonVegMeal.ShowItems();
Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());

Console.ReadLine();
