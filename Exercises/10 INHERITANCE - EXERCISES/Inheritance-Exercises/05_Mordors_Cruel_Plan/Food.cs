using System.Collections.Generic;

public class Food
{
    private string name;

    public Food(string name)
    {
        Name = name;
    }

    public string Name
    {
        get => name;
        set => name = value.ToLower();
    }
}

