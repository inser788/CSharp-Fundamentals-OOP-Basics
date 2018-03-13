﻿public class SonicHarvester:Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement,int sonicFactor) 
        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement = this.EnergyRequirement / sonicFactor;
    }

    public int SonicFactor
    {
        get => sonicFactor;
        set => sonicFactor = value;
    }
}

