    using System;

public class StartUp
{
    public static void Main()
    {
        Family family=new Family();
        int numberlines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberlines; i++)
        {
            var inputPersons = Console.ReadLine()
                .Split();
            string name = inputPersons[0];
            int age = int.Parse(inputPersons[1]);

            var person=new Person(name,age);
            family.AddMember(person);
        }

        var oldestMember = family.GetOldestMember();
        
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}

