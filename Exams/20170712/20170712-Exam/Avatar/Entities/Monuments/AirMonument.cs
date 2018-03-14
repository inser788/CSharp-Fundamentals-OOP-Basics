public class AirMonument : Monument
{
    public AirMonument(string name,int airAffinity) 
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity { get; protected set; }
    public override int GetMonumentBonus()
    {
        return this.AirAffinity;
    }
}

