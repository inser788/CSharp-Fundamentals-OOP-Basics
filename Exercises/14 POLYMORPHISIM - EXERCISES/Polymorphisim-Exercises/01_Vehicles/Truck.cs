﻿public class Truck : Vehicle
{
    private const double fuelConsumptionIncrease = 1.6;
    private const double fuelEfficiency = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption + fuelConsumptionIncrease)
    {
    }

    public override void Refuel(double liters)
    {
        base.Refuel(liters * fuelEfficiency);
    }
}