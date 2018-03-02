public class Repair:IRepair
{
    private string partName;
    private int hoursWork;

    public Repair(string partName, int hoursWork)
    {
        PartName = partName;
        HoursWork = hoursWork;
    }

    public string PartName
    {
        get => partName;
        set => partName = value;
    }

    public int HoursWork
    {
        get => hoursWork;
        set => hoursWork = value;
    }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.HoursWork}";
    }
}

