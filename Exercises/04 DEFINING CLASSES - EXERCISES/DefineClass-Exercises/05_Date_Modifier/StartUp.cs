using System;
using System.Globalization;

public class StartUp
{
    public static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        int daysValue=DateModifier.GetDaysDifference(firstDate, secondDate);
        Console.WriteLine(daysValue);
    }
}

