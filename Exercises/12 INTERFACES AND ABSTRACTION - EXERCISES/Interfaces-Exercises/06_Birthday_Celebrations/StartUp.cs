using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        List<IBirthdate> listOfMembers = GetListOfMembers();
        PrintSearchedMembers(listOfMembers);
    }

    private static void PrintSearchedMembers(List<IBirthdate> listOfMembers)
    {
        string searchedYear = Console.ReadLine();
        foreach (var member in listOfMembers)
        {
            if (member.BirthDate.EndsWith(searchedYear))
            {
                Console.WriteLine(member.BirthDate);
            }
        }
    }
    
    private static List<IBirthdate> GetListOfMembers()
    {
        var list=new List<IBirthdate>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End") break;

            IBirthdate member = GetMember(input);
            if (member == null)
                continue;
            list.Add(member);
        }

        return list;
    }

    private static IBirthdate GetMember(string input)
    {
        IBirthdate obj = null;
        string[] dataReceived = input.Split();
        switch (dataReceived[0].ToLower())
        {
            case "citizen": obj= new Citizen(dataReceived[1], int.Parse(dataReceived[2]), dataReceived[3], dataReceived[4]);
                break;
            case "pet":obj= new Pet(dataReceived[1],dataReceived[2]);
                break;
        }

        return obj;
    }
}

