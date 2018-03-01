public class Pet:IBirthdate
{
    private string name;
    private string birthDate;

    public Pet(string name, string birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    public string Name
    {
        get => name;
       private set => name = value;
    }

    public string BirthDate
    {
        get => birthDate;
        set => birthDate = value;
    }
}

