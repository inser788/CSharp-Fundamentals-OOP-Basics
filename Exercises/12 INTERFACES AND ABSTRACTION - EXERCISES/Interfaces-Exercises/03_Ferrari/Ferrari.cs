public class Ferrari:ICar
{
    private const string modelName = "488-Spider";

    private string model;
    private string driverName;

    public Ferrari(string driverName)
    {
        DriverName = driverName;
    }

    public string Model
    {
        get => model = modelName;
    }

    public string DriverName
    {
        get => driverName;
        set => driverName = value;
    }
    
    public string BreaksMessage()
    {
        return $"Brakes!";
    }

    public string GasPedalMessage()
    {
        return $"Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.BreaksMessage()}/{this.GasPedalMessage()}/{this.DriverName}";
    }
}

