using System.Collections.Generic;
using System.Linq;

public class Car
{
    private string modelCar;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

    public Car(string modelCar, Engine engine, Cargo cargo, List<Tire> tires)
    {
        this.modelCar = modelCar;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }

    public string ModelCar
    {
        get => modelCar;
        set => modelCar = value;
    }

    public bool IsFragile()
    {
        return this.cargo.CargoType == "fragile" &&
               this.tires.Any(t => t.TirePressure < 1);
    }

    public bool IsFlamable()
    {
        return this.cargo.CargoType == "flamable" &&
               this.engine.EnginePower > 250;
    }

    public override string ToString()
    {
        return $"{this.ModelCar}";
    }
}

