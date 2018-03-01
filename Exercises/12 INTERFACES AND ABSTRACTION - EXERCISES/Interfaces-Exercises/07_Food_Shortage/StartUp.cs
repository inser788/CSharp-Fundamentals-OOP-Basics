using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        HashSet<IMember> listOfMembers = GetListOfMembers();
        CalculateAllFoodPrice(listOfMembers);
    }

    private static void CalculateAllFoodPrice(HashSet<IMember> listOfMembers)
    {
        int totalAmountFood = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End") break;
            if (listOfMembers.Any(m => m.Name == input))
            {
                totalAmountFood += listOfMembers.First(x => x.Name == input).BuyFood();
            }
        }

        Console.WriteLine(totalAmountFood);
    }

    private static HashSet<IMember> GetListOfMembers()
    {
        var list = new HashSet<IMember>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            string[] inputData = Console.ReadLine().Split();
            IMember member = null;
            if (inputData.Length == 3)
            {
                member = new Rebel(inputData[0], int.Parse(inputData[1]), inputData[2]);
            }
            else if (inputData.Length == 4)
            {
                member = new Citizen(inputData[0], int.Parse(inputData[1]), inputData[2], inputData[3]);
            }

            if (member == null)
                continue;
            list.Add(member);
        }

        return list;
    }
}

