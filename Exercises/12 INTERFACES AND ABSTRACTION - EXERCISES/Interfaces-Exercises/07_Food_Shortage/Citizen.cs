public class Citizen : IMember
{
    private string name;
    private int age;
    private string id;
    private string birthDate;
    private int food;

    public Citizen(string name, int age, string id, string birthDate)
    {
        Name = name;
        Age = age;
        Id = id;
        BirthDate = birthDate;
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

    private string Id
    {
        get => id;
        set => id = value;
    }

    private string BirthDate
    {
        get => birthDate;
        set => birthDate = value;
    }

    public int Food
    {
        get => 10;
    }
    public int BuyFood()
    {
        return this.Food;
    }
}

