using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public string FirstName
    {
        get => firstName;
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get => lastName;
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }

            this.lastName = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }

            this.age = value;
        }
    }

    public decimal Salary
    {
        get => salary;
        set
        {
            if (value<460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }

            this.salary = value;
        }
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age < 30)
        {
            this.salary += salary * percentage / 200m;
        }
        else
        {
            this.salary += salary * percentage / 100m;
        }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} receives {this.salary:f2} leva.";
    }
}

