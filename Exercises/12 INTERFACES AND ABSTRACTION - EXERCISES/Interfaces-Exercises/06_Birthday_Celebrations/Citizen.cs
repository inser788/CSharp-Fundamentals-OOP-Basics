public class Citizen : IBirthdate
{
    private string name;
    private int age;
    private string id;
    private string birthdate;

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        BirthDate = birthdate;
    }

    public string Name
    {
        get => name;
        private set => name = value;
    }

    public int Age
    {
        get => age;
        private set => age = value;
    }

    public string Id
    {
        get => id;
        private set => id = value;
    }

    public string BirthDate
    {
        get => birthdate;
        set => birthdate = value;
    }

}

