using System;

public class StartUp
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Beast!")
                break;
            try
            {
                Animal animal = GetTypeOfAnimal(input);
                Console.WriteLine(animal.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

    private static Animal GetTypeOfAnimal(string input)
    {
        string[] animalData = Console.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
        switch (input.ToLower())
        {
            case "dog": return new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
            case "cat": return new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
            case "frog": return new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
            case "kitten": return new Kitten(animalData[0], int.Parse(animalData[1]));
            case "tomcat": return new Tomcat(animalData[0], int.Parse(animalData[1]));
            default:
                throw new ArgumentException("Invalid input!");
        }
    }
}

