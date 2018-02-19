 using System;
 using System.Collections.Generic;
 using System.Linq;

public class StartUp
{
    static void Main()
    {
        GetPersons()
            .Where(x=>x.Age>30)
            .OrderBy(n=>n.Name)
            .ToList()
            .ForEach(p=>Console.WriteLine(p.ToString()));
    }

    public static List<Person> GetPersons()
    {
        var persons=new List<Person>();
        int numberOfPerson = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPerson; i++)
        {
            string[] inputData = Console.ReadLine().Split();
            string name = inputData[0];
            int age = int.Parse(inputData[1]);
            Person person=new Person(name,age);
            persons.Add(person);
        }

        return persons;
    }
}
