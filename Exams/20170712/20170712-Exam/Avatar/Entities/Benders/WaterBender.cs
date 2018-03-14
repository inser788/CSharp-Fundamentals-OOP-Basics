public class WaterBender : Bender
{
    public WaterBender(string name, int power,double waterClarity)
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public double WaterClarity { get;protected set; }


    public override double GetTotalPower()
    {
        return WaterClarity * base.Power;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Water Clarity: {this.WaterClarity:f2}";
    }
}

