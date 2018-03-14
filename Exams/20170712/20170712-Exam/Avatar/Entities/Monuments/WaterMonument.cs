public class WaterMonument : Monument
{
    public WaterMonument(string name,int waterAffinity)
        : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int WaterAffinity { get; protected set; }

    public override int GetMonumentBonus()
    {
        return this.WaterAffinity;
    }
}

