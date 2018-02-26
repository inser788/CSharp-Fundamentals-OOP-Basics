using System;
using System.Collections.Generic;

public class Person
{
    private string namePerson;
    private double moneyPerson;
    private List<Product> bagPerson;

    public Person(string namePerson, double moneyPerson)
    {
        this.bagPerson = new List<Product>();
        NamePerson = namePerson;
        MoneyPerson = moneyPerson;
    }

    public string NamePerson
    {
        get => namePerson;
        set
        {
            if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.namePerson = value;
        }
    }

    public double MoneyPerson
    {
        get => moneyPerson;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.moneyPerson = value;
        }
    }

    public List<Product> BagPerson => bagPerson;

    public string MessageCanAddProduct(Product product)
    {
        if (this.moneyPerson - product.Price >= 0)
        {
            this.bagPerson.Add(product);
            this.MoneyPerson -= product.Price;
            return $"{(this.namePerson)} bought {(product.Name)}";
        }
        else
        {
            return $"{this.namePerson} can't afford {product.Name}";
        }

    }
}

