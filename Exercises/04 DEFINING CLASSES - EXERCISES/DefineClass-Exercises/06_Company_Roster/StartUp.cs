using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var allEmployes = new List<Employee>();
        int numberOfLines = int.Parse(Console.ReadLine());
        allEmployes = GetListOfAllEmployees(numberOfLines);
        var searchedDept = allEmployes
            .GroupBy(e => e.Department)
            .Select(p => new
            {
                Department = p.Key,
                AverageSalary = p.Average(sal => sal.Salary),
                Employees = p.OrderByDescending(e => e.Salary).ToList()
            })
            .OrderByDescending(x => x.AverageSalary)
            .FirstOrDefault();

        if (searchedDept!=null)
        {
            Console.WriteLine($"Highest Average Salary: {searchedDept.Department}");
            searchedDept.Employees
                .ForEach(e=>Console.WriteLine(e.ToString()));
        }
    }

    private static List<Employee> GetListOfAllEmployees(int numberOfLines)
    {
        var listTemporary=new List<Employee>();
        for (int i = 0; i < numberOfLines; i++)
        {
            string[] inputData = Console.ReadLine().Split();
            string name = inputData[0];
            decimal salary = decimal.Parse(inputData[1]);
            string position = inputData[2];
            string department = inputData[3];
            Employee currentEmploy=new Employee(name,salary,position,department);
            if (inputData.Length==5)
            {
                var emailOrAge = inputData[4];
                if (emailOrAge.Contains("@"))
                {
                    currentEmploy.Email = emailOrAge;
                }
                else
                {
                    currentEmploy.Age = int.Parse(emailOrAge);
                }
            }

            if (inputData.Length==6)
            {
                currentEmploy.Email = inputData[4];
                currentEmploy.Age = int.Parse(inputData[5]);
            }
            listTemporary.Add(currentEmploy);
        }
        return listTemporary;
    }
}

