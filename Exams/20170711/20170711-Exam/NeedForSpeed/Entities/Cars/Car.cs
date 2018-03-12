using System;
using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;
    private int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension,
        int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsePower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public int HorsePower
    {
        get => horsePower;
        set => horsePower = value;
    }

    public int Suspension
    {
        get => suspension;
        set => suspension = value;
    }

    public int Acceleration => acceleration;

    public int Durability => durability;

    public string Brand => brand;

    public string Model => model;

    public int YearOfProduction => yearOfProduction;

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{brand} {model} {yearOfProduction}")
            .AppendLine($"{horsePower} HP, 100 m/h in {acceleration} s")
            .AppendLine($"{suspension} Suspension force, {durability} Durability");

        return sb.ToString();
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.HorsePower += tuneIndex;
        this.Suspension += tuneIndex * 1 / 2;
    }
}

