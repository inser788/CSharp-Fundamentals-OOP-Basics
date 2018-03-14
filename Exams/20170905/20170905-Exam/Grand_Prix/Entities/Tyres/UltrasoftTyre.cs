using System;

public class UltrasoftTyre : Tyre
{
    private double tyreDegradation;

    public UltrasoftTyre(double tyreHardness, int grip)
        : base(tyreHardness)
    {
        this.Grip = grip;
    }

    public int Grip { get; protected set; }

    public override string TyreType => "Ultrasoft";

    public override double TyreDegradation
    {
        get => this.tyreDegradation;
        protected set
        {
            if (value < 30)
            {
                throw new ArgumentException("Blown Tyre");
            }

            this.tyreDegradation = value;
        }
    }

    public override void ReduceDegradation()
    {
        var sum = this.TyreHardness - this.Grip;
        this.TyreDegradation -= sum;
    }
}

