public class FireBender : Bender
{
    public FireBender(string name, int power,double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public double HeatAggression { get; protected set; }


    public override double GetTotalPower()
    {
        return HeatAggression * base.Power;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Water Clarity: {this.HeatAggression:f2}";
    }
}

