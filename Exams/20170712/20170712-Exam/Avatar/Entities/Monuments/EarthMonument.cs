public class EarthMonument : Monument
{
    public EarthMonument(string name,int earthAffinity)
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public int EarthAffinity { get; protected set; }

    public override int GetMonumentBonus()
    {
        return this.EarthAffinity;
    }
}

