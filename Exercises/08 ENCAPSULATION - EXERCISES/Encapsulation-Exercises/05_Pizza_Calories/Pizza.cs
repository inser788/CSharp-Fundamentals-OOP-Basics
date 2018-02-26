using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dough doughType;
    private List<Topping> listOfToppings;

    public Pizza(string name)
    {
        this.listOfToppings = new List<Topping>();
        Name = name;
    }

    public Pizza(string name, Dough doughType):this(name)
    {
        DoughType = doughType;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            if (value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public Dough DoughType
    {
        set => doughType = value;
    }

 
    public void AddTopping(Topping topping)
    {
        this.listOfToppings.Add(topping);
        if (listOfToppings.Count>10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    public double GetAllCalories()
    {
        return this.doughType.GetTotalCalories() + this.listOfToppings.Sum(a => a.GetTotalCalories());
    }

    public override string ToString()
    {
        return $"{this.name} - {this.GetAllCalories():f2} Calories.";
    }
}

