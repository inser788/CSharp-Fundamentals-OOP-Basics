using System;

public class Topping
{
    //Modifyers for Topping
    private const double Meat = 1.2;
    private const double Veggies = 0.8;
    private const double Cheese = 1.1;
    private const double Sauce = 0.9;

    //Min an Max Topping weight
    private const double MinWeight = 1;
    private const double MaxWeight = 50;

    private string toppingType;
    private double toppingWeight;

    public Topping(string toppingType, double toppingWeight)
    {
        ToppingType = toppingType;
        ToppingWeight = toppingWeight;
    }

    public string ToppingType
    {
        get => toppingType;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                &&value.ToLower()!="cheese"&&value.ToLower()!="sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            this.toppingType = value;
        }
    }

    public double ToppingWeight
    {
        get => toppingWeight;
        set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
            }

            this.toppingWeight = value;
        }
    }

    public double GetTotalCalories()
    {
        double modifyer = 2;
        switch (toppingType.ToLower())
        {
            case "meat":
                modifyer *= Meat;
                break;
            case "veggies":
                modifyer *= Veggies;
                break;
            case "cheese":
                modifyer *= Cheese;
                break;
            case "sauce":
                modifyer *= Sauce;
                break;
        }

        return this.toppingWeight * modifyer;
    }
}

