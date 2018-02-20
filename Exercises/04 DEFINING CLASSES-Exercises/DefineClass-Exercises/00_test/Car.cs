using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double consumationFuel;
    private double distanceTraveled;

    public Car(string model, double fuelAmount, double consumationFuel)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.consumationFuel = consumationFuel;
        this.distanceTraveled = 0;
    }

    public string Model
    {
        get => model;
        set => model = value;
    }

    public double FuelAmount
    {
        get => fuelAmount;
        set => fuelAmount = value;
    }

    public double ConsumationFuel
    {
        get => consumationFuel;
        set => consumationFuel = value;
    }

    public void Drive(int distance)
    {
        if (this.consumationFuel*distance<=this.fuelAmount)
        {
            this.distanceTraveled += distance;
            this.fuelAmount -= this.consumationFuel * distance;
        }
        else
        {
            Console.WriteLine($"Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:f2} {this.distanceTraveled}";
    }
}

