using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private IList<IRepair> repairs;

    public IList<IRepair> Repairs
    {
        get => repairs;
        set => repairs = value;
    }


    public Engineer(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new List<IRepair>();
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder
            .AppendLine(base.ToString())
            .AppendLine("Repairs:");

        foreach (var repair in this.repairs)
        {
            builder.AppendLine($"  {repair}");
        }

        return builder.ToString().Trim();
    }
}

