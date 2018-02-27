using System;
using System.Text;

public class Worker : Human
{
    private const int minSalary = 10;
    private const decimal minHoursWorkingDay = 1;
    private const decimal maxHoursWorkingDay = 12;
    private const decimal workingDaysInWeek = 5;

    private decimal weekSalary;
    private decimal weekHours;

    public Worker(string firtName, string lastName, decimal weekSalary, decimal weekHours)
        : base(firtName, lastName)
    {
        WeekSalary = weekSalary;
        WeekHours = weekHours;
    }

    public decimal WeekSalary
    {
        get => weekSalary;
        protected set
        {
            if (value <= minSalary)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }

            this.weekSalary = value;
        }
    }

    public decimal WeekHours
    {
        get => weekHours;
        protected set
        {
            if (value < minHoursWorkingDay || value > maxHoursWorkingDay)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }

            this.weekHours = value;
        }
    }

    public decimal GetSalaryPerHour()
    {
        return this.weekSalary / (workingDaysInWeek * this.weekHours);
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.WeekHours:f2}")
            .AppendLine($"Salary per hour: {this.GetSalaryPerHour():f2}");

        return builder.ToString().TrimEnd();
    }
}

