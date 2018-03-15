using System;
using System.Linq;

public class Engine
{
    private NationsBuilder nationBuilder;
    private string[] input;
    private bool isRunning;

    public Engine()
    {
        this.nationBuilder = new NationsBuilder();
        isRunning = true;
    }

    public void Run()
    {


        while (isRunning)
        {
            input = Console.ReadLine().Split();
            string command = input[0];
            var arguments = input.Skip(1).ToList();
            switch (command)
            {
                case "Bender":
                    nationBuilder.AssignBender(arguments);
                    break;
                case "Monument":
                    nationBuilder.AssignMonument(arguments);
                    break;
                case "Status":
                    Console.WriteLine(nationBuilder.GetStatus(arguments[0]));
                    break;
                case "War":
                    nationBuilder.IssueWar(arguments[0]);
                    break;
                case "Quit":
                    Console.WriteLine(nationBuilder.GetWarsRecord());
                    isRunning = false;
                    break;
            }
        }
    }
}

