   using System;
   using System.Collections.Generic;
   using System.IO;

public class StartUp
{
    static void Main(string[] args)
    {
        var carsInfo = GetCarsInfo();
        carsInfo = DriveCars(carsInfo);
        PrintCars(carsInfo);
    }

    private static void PrintCars(Dictionary<string, Car> carsInfo)
    {
        foreach (var car in carsInfo)
        {
            Console.WriteLine(car.Value.ToString());
        }
    }

    private static Dictionary<string, Car> DriveCars(Dictionary<string, Car> carsInfo)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input=="End")
            break;
            string[] tokens = input.Split();
            string modelCar = tokens[1];
            int distance = int.Parse(tokens[2]);
            if (carsInfo.ContainsKey(modelCar))
            {
                carsInfo[modelCar].Drive(distance);
            }
        }

        return carsInfo;
    }

    private static Dictionary<string, Car> GetCarsInfo()
    {
        var carsInfo=new Dictionary<string,Car>();
        int numberOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCars; i++)
        {
            string[] input = Console.ReadLine().Split();
            string model = input[0];
            double fuelAmount = double.Parse(input[1]);
            double fuelConsumation = double.Parse(input[2]);

            Car car=new Car(model,fuelAmount,fuelConsumation);
            if (!carsInfo.ContainsKey(model))
            {
                carsInfo[model] = car;
            }
        }

        return carsInfo;
    }
}
