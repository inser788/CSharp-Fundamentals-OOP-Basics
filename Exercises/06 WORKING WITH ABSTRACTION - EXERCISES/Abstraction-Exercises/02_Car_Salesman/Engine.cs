public class Engine
{
    private string engineModel;
    private double enginePower;
    private string engineDisplacement;
    private string engineEfficiency;

    public Engine(string engineModel, double enginePower)
    {
        this.engineModel = engineModel;
        this.enginePower = enginePower;
        this.engineDisplacement = "n/a";
        this.engineEfficiency = "n/a";
    }

    public string EngineModel
    {
        get => engineModel;
        set => engineModel = value;
    }

    public double EnginePower
    {
        get => enginePower;
        set => enginePower = value;
    }

    public string EngineDisplacement
    {
        get => engineDisplacement;
        set => engineDisplacement = value;
    }

    public string EngineEfficiency
    {
        get => engineEfficiency;
        set => engineEfficiency = value;
    }
}

