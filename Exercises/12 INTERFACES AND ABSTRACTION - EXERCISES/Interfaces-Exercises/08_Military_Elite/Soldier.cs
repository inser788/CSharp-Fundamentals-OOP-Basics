using System.Text;

public abstract class Soldier:ISoldier
{
    private string id;
    private string firstName;
    private string lastName;

    protected Soldier(string id, string firstName, string lastName)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string Id => id;

    public string FirstName => firstName;

    public string LastName => lastName;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");

        return builder.ToString().Trim();
    }
}

