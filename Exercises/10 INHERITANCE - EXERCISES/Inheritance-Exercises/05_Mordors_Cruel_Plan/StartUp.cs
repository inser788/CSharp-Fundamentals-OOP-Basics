using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var listFood = new List<Food>();
        int initialHappiness = 0;
        string[] input = Console.ReadLine().Split(" \t".ToCharArray());
        for (int i = 0; i < input.Length; i++)
        {
            Food food=new Food(input[i]);
            listFood.Add(food);
        }

        //  	Cram: 2 points of happiness;
        //  	Lembas: 3 points of happiness;
        //  	Apple: 1 point of happiness;
        //  	Melon: 1 point of happiness;
        //  	HoneyCake: 5 points of happiness;
        //  	Mushrooms: -10 points of happiness;
        //  	Everything else: -1 point of happiness;


        foreach (var food in listFood)
        {
            switch (food.Name.ToLower())
            {
                case "cram": initialHappiness += 2;break;
                case "lembas": initialHappiness += 3; break;
                case "apple": initialHappiness += 1; break;
                case "melon": initialHappiness += 1; break;
                case "honeycake": initialHappiness += 5; break;
                case "mushrooms": initialHappiness -= 10; break;
                    default: initialHappiness -= 1;break;
            }
        }

        Console.WriteLine(initialHappiness);
        if (initialHappiness<-5)
        {
            Console.WriteLine("Angry");
        }
        else if (initialHappiness>=-5&&initialHappiness<=0)
        {
            Console.WriteLine("Sad");
        }
        else if (initialHappiness>=1&&initialHappiness<=15)
        {
            Console.WriteLine("Happy");
        }
        else
        {
            Console.WriteLine("JavaScript");
        }
    }
}

