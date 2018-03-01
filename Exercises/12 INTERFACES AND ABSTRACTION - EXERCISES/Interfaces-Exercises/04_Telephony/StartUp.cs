using System;

public class StartUp
{
    static void Main()
    {
        Smartphone phone = new Smartphone();
        string[] inputCallNumbers = Console.ReadLine().Split(" \t".ToCharArray());
        string[] inputWebSites = Console.ReadLine().Split(" \t".ToCharArray());

        foreach (var number in inputCallNumbers)
        {
            Console.WriteLine(phone.Call(number));
        }

        foreach (var site in inputWebSites)
        {
            Console.WriteLine(phone.BrowseSite(site));
        }
    }
}

