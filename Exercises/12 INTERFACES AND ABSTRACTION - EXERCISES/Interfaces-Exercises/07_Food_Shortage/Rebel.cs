public class Rebel:IMember
{
    private string name;
    private int age;
    private string group;
    private int food;

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    private int Age
    {
        get => age;
        set => age = value;
    }

    private string Group
    {
        get => @group;
        set => @group = value;
    }

    public int Food
    {
        get => 5;
    }
    public int BuyFood()
    {
        return this.Food;
    }
}

