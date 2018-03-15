public abstract class Bender
{
    public string Name { get; protected set; }

    public int  Power { get; protected set; }

    protected Bender(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public abstract double GetTotalPower();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Bender");
        name=name.Insert(index, " ");

        return $"###{name}: {this.Name}, Power: {this.Power},";
    }
}

