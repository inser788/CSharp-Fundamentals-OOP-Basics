public abstract class Monument
{
    public string Name { get;protected set; }

    protected Monument(string name)
    {
        Name = name;
    }

    public abstract int GetMonumentBonus();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Monument");
       name= name.Insert(index, " ");

        return $"###{name}: {this.Name},";
    }
}

