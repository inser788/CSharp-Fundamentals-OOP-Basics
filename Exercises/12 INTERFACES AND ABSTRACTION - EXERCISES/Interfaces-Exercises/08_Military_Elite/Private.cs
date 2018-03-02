﻿using System.Text;

public class Private:Soldier,IPrivate
{
    private double salary;

    public Private(string id, string firstName, string lastName,double salary)
        : base(id, firstName, lastName)
    {
        this.salary = salary;
    }

    public double Salary => salary;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder
            .Append(base.ToString())
            .Append($" Salary: {this.Salary:f2}");

        return builder.ToString().Trim();
    }
}

