using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class StartUp
{
    static void Main()
    {
        List<Car> carsInfo = GetCarsInfo();
        string caseCommand = Console.ReadLine();
        var searchedModels = GetSearchedModels(carsInfo, caseCommand);
        searchedModels.ForEach(m=>Console.WriteLine(m.ToString()));
    }

    private static List<Car> GetSearchedModels(List<Car> carsInfo, string cargoType)
    {
        switch (cargoType)
        {
            case "fragile":
                return carsInfo.Where(c => c.IsFragile()).ToList();
            case "flamable":
                return carsInfo.Where(c => c.IsFlamable()).ToList();
                default: return null;
        }
    }

    private static List<Car> GetCarsInfo()
    {
        List<Car> listCarInfo = new List<Car>();
        int inputLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < inputLines; i++)
        {
            string[] inputData = Console.ReadLine().Split();
            string model = inputData[0];

            int engineSpeed = int.Parse(inputData[1]);
            int enginePower = int.Parse(inputData[2]);

            Engine engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(inputData[3]);
            string cargoType = inputData[4];

            Cargo cargo = new Cargo(cargoWeight, cargoType);

            var tires = new List<Tire>();
            int counter = 0;
            for (int j = 0; j < 4; j++)
            {
                double tirePressure = double.Parse(inputData.Skip(5 + counter++).First());
                int tireAge = int.Parse(inputData.Skip(5 + counter++).First());
                Tire tire = new Tire(tirePressure, tireAge);
                tires.Add(tire);
            }

            Car currenCar = new Car(model, engine, cargo, tires);
            listCarInfo.Add(currenCar);
        }

        return listCarInfo;
    }
}

