using System;


public class FoodType
{
    private string name;
    private int protein;
    private int carbs;
    private int fat;

    public FoodType(string name, int protein, int carbs, int fat)
    {
        this.name = name;
        this.protein = protein;
        this.carbs = carbs;
        this.fat = fat;
    }

    public string GetName()
    {
        return name;
    }

    public int GetProtein()
    {
        return protein;
    }

    public int GetCarbs()
    {
        return carbs;
    }

    public int GetFat()
    {
        return fat;
    }

    public override string ToString()
    {
        return "${name}: p - {protein}%, c - {carbs}%, f - {fat}%";
    }
}

public class Food
{
    private FoodType type;
    private int weight;

    public Food(FoodType type, int weight)
    {
        this.type = type;
        this.weight = weight;
    }

    public string ToStringInGrams()
    {
        double proteinInGrams = type.GetProtein() * weight / 100.0;
        double carbsInGrams = type.GetCarbs() * weight / 100.0;
        double fatInGrams = type.GetFat() * weight / 100.0;

        return "${type.GetName()}: p - {proteinInGrams:F1}g, c - {carbsInGrams:F1}g, f - {fatInGrams:F1}g, w - {weight}g";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        FoodType foodType = new FoodType("banana", 4, 93, 3);
        Food food = new Food(foodType, 110);

        Console.WriteLine(food.ToStringInGrams());
    }
}