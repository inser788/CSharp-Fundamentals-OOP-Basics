using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class NationsBuilder
{

    private Dictionary<string, Nation> nations;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air", new Nation()},
            {"Earth", new Nation()},
            {"Fire", new Nation()},
            {"Water", new Nation()},

        };
    }

    public void AssignBender(List<string> benderArgs)
    {

        string type = benderArgs[0];
        string name = benderArgs[1];
        int power = int.Parse(benderArgs[2]);
        double secondParameter = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddBender(new AirBender(name, power, secondParameter));
                break;
            case "Earth":
                this.nations[type].AddBender(new EarthBender(name, power, secondParameter));
                break;
            case "Fire":
                this.nations[type].AddBender(new FireBender(name, power, secondParameter));
                break;
            case "Water":
                this.nations[type].AddBender(new WaterBender(name, power, secondParameter));
                break;
        }

    }

    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[0];
        string name = monumentArgs[1];
        int affinity = int.Parse(monumentArgs[2]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddMonument(new AirMonument(name, affinity));
                break;
            case "Earth":
                this.nations[type].AddMonument(new EarthMonument(name, affinity));
                break;
            case "Fire":
                this.nations[type].AddMonument(new FireMonument(name, affinity));
                break;
            case "Water":
                this.nations[type].AddMonument(new WaterMonument(name, affinity));
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        switch (nationsType)
        {
            case "Air":
                
                break;

            case "Earth":
                break;

            case "Fire":
                break;
            case "Water":
                break;

        }

        return "";
    }

    public void IssueWar(string nationsType)
    {
        //TODO: Add some logic here … 
    }

    public string GetWarsRecord()
    {
        //TODO: Add some logic here … 
        return "";
    }

}

