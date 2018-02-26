using System;

public class StartUp
{
    static void Main()
    {
        try
        {
            string input = Console.ReadLine();

            string[] command = input.Split();
            Pizza pizza = new Pizza(command[1]);

            input = Console.ReadLine();
            string[] cmdArgs = input.Split();

            Dough dough = new Dough(cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]));
            pizza.DoughType = dough;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "END")
                    break;
                cmdArgs = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Topping topping = new Topping(cmdArgs[1], double.Parse(cmdArgs[2]));
                pizza.AddTopping(topping);

            }

            Console.WriteLine(pizza.ToString());
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

