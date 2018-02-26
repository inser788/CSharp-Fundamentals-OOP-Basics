using System;

public class Dough
{
    //Modifyers for Dough
    private const double White = 1.5;
    private const double Wholegrain = 1.0;
    private const double Crispy = 0.9;
    private const double Chewy = 1.1;
    private const double Homemade = 1.0;

    //Min an Max Dough weight
    private const double MinWeight = 1;
    private const double MaxWeight = 200;


    private string flourType;
    private string bakeTechnique;
    private double weightInGrams;

    public Dough(string flourType, string bakeTechnique, double weightInGrams)
    {
        FlourType = flourType;
        BakeTechnique = bakeTechnique;
        WeightInGrams = weightInGrams;
    }

    public string FlourType
    {
        get => flourType;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.flourType = value;
        }
    }

    public string BakeTechnique
    {
        get => bakeTechnique;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.bakeTechnique = value;
        }
    }

    public double WeightInGrams
    {
        get => weightInGrams;
        set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.weightInGrams = value;
        }
    }


    public double GetTotalCalories()
    {
        double modifyer = 2;
        if (this.flourType.ToLower() == "white")
        {
            switch (bakeTechnique.ToLower())
            {
                case "crispy":
                    modifyer *= White * Crispy;
                    break;
                case "chewy":
                    modifyer *= White * Chewy;
                    break;
                case "homemade":
                    modifyer *= White * Homemade;
                    break;
            }

            return this.weightInGrams * modifyer;
        }

        switch (bakeTechnique.ToLower())
        {
            case "crispy":
                modifyer *= Wholegrain * Crispy;
                break;
            case "chewy":
                modifyer *= Wholegrain * Chewy;
                break;
            case "homemade":
                modifyer *= Wholegrain * Homemade;
                break;
        }

        return this.weightInGrams * modifyer;

    }
}

