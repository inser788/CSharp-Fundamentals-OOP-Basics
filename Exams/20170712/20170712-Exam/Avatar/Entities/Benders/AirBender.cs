public class AirBender : Bender
{
    public AirBender(string name, int power,double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity { get;protected set; }

    public override double GetTotalPower()
    {
        return AerialIntegrity * base.Power;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}

