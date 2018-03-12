using System.Text;

public class ShowCar:Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int stars, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, stars, durability)
    {
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"{this.stars} *");

        return sb.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.stars += tuneIndex;
    }
}

