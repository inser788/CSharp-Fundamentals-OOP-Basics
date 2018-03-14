public class FireMonument : Monument
{
    public FireMonument(string name,int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public int FireAffinity { get; protected set; }

    public override int GetMonumentBonus()
    {
        return this.FireAffinity;
    }
}

