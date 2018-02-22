using System;

public class Box
{
    private double length;
    private double width;
    private double height;
    private double surfaceArea;
    private double lateralSurfaceArea;
    private double volume;

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double Length
    {
        get => length;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }

            this.length = value;
        }
    }

    public double Width
    {
        get => width;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this.width = value;
        }
    }

    public double Height
    {
        get => height;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.height = value;
        }
    }

    //Volume = lwh
    //Lateral Surface Area = 2lh + 2wh
    //Surface Area = 2lw + 2lh + 2wh

    public void GetSurfaceArea()
    {
        this.surfaceArea = 2 * (length * width + length * height + width * height);
    }

    public void GetLateralSurfaceArea()
    {
        this.lateralSurfaceArea = 2 * (length * height + width * height);
    }

    public void GetVolume()
    {
        this.volume = length * width * height;
    }

    public override string ToString()
    {
        return $"Surface Area - {this.surfaceArea:f2}\n" +
               $"Lateral Surface Area - {this.lateralSurfaceArea:f2}\n" +
               $"Volume - {this.volume:f2}";
    }
}

