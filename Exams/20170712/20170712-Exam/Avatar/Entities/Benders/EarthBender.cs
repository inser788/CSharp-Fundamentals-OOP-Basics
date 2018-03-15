public class EarthBender : Bender
{
    public EarthBender(string name, int power,double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public double GroundSaturation { get;protected set; }


    public override double GetTotalPower()
    {
        return GroundSaturation * base.Power;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Ground Saturation: {this.GroundSaturation:f2}";
    }
}

