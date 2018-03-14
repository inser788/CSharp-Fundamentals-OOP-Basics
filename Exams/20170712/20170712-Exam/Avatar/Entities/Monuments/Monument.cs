public abstract class Monument
{
    public string Name { get;protected set; }

    protected Monument(string name)
    {
        Name = name;
    }

    public abstract int GetMonumentBonus();

}

