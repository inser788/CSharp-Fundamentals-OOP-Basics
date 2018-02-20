using System;

public class StartUp
{
    public static void Main()
    {
      Person person=new Person();
        Person person1=new Person(34);
        Person person2=new Person("sfdsdf",23);

        Console.WriteLine($"{person.Name}  {person.Age}");
        Console.WriteLine($"{person1.Name}  {person1.Age}");
        Console.WriteLine($"{person2.Name}  {person2.Age}");

    }
}

