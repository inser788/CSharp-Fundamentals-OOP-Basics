using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var listOfIds = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if(input=="End") break;
            string[] dataPerson = input.Split();
            if (dataPerson.Length==2)
            {
               listOfIds.Add(dataPerson[1]);
            }

            if (dataPerson.Length==3)
            {
                listOfIds.Add(dataPerson[2]);
            }
        }

        string badIdEnd = Console.ReadLine();
        foreach (var id in listOfIds)
        {
            if (id.EndsWith(badIdEnd))
            {
                Console.WriteLine(id);
            }
        }
    }
}

