 using System;

public class HardTyre : Tyre
{
    private double tyreDegradation;

    public HardTyre(double tyreHardness) : base(tyreHardness)
    {
    }

    public override string TyreType =>  "Hard";

    public override double TyreDegradation
    {
        get => this.tyreDegradation;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Blown Tyre");
            }

            this.tyreDegradation = value;
        }
    }

    public override void ReduceDegradation()
    {
        this.TyreDegradation -= this.TyreHardness;
    }
}

