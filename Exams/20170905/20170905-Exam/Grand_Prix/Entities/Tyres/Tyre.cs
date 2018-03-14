using System;

public abstract class Tyre
{
    private double tyreDegradation = 100;

    public abstract string TyreType { get; }

    public double TyreHardness { get; protected set; }

    protected Tyre(double tyreHardness)
    {
        TyreHardness = tyreHardness;
    }

    public virtual double TyreDegradation
    {
        get => tyreDegradation;
       protected set => tyreDegradation = value;
    }

    public virtual void ReduceDegradation()
    {
    }
}

