using System;

public class StartUp
{
    static void Main()
    {
        string input = Console.ReadLine();
        ICar car=new Ferrari(input);
        Console.WriteLine(car.ToString());
    }
}

