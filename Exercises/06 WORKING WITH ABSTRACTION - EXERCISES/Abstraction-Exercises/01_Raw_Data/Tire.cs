public class Tire
{
    private double tirePressure;
    private int tireAge;

    public Tire(double tirePressure, int tireAge)
    {
        this.tirePressure = tirePressure;
        this.tireAge = tireAge;
    }

    public int TireAge
    {
        get => tireAge;
        set => tireAge = value;
    }

    public double TirePressure
    {
        get => tirePressure;
        set => tirePressure = value;
    }
}

