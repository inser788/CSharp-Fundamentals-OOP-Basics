using System;

public class Product
{
    private string name;
    private double price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value)|| string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public double Price
    {
        get => price;
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.price = value;
        }
    }
}

