using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager manager;
    private bool isRunning = true;

    public Engine()
    {
        this.manager = new DraftManager();
    }


    public void Run()
    {
        while (this.isRunning)
        {
            string command = Console.ReadLine();

            List<string> cmdArgs = command.Split().ToList();
            ExecuteCommand(cmdArgs);
        }

    }

    private void ExecuteCommand(List<string> cmdArgs)
    {
        string command = cmdArgs[0];
        var tokens = cmdArgs.Skip(1).ToList();
        string output;
        switch (command)
        {
            case "RegisterHarvester":
               output=  manager.RegisterHarvester(tokens);
                Console.WriteLine(output);
                break;
            case "RegisterProvider":
              output=   manager.RegisterProvider(tokens);
                Console.WriteLine(output);
                break;
            case "Day":
                output = manager.Day();
                Console.WriteLine(output);
                break;

            case "Mode":
                output = manager.Mode(tokens);
                Console.WriteLine(output);
                break;

            case "Check":
                output = manager.Check(tokens);
                Console.WriteLine(output);
                break;
            case "Shutdown":
                output = this.manager.ShutDown();
                Console.WriteLine(output);
                isRunning = false;
                break;
        }
    }
}

