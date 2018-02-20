using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        List<Engine> enginesInfo = GetEnginesInfo();
        List<Car> carsInfo = GetCarsInfo(enginesInfo);
        PrintCarsInfo(carsInfo);
    }

    private static void PrintCarsInfo(List<Car> carsInfo)
    {
        carsInfo.ForEach(c=>Console.WriteLine(c.ToString()));
    }

    private static List<Car> GetCarsInfo(List<Engine> enginesInfo)
    {
        List<Car> carsInfo=new List<Car>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            string[] inputData = Console.ReadLine().Trim().Split();
            string carModel = inputData[0];
            string engineModelName = inputData[1];
            Engine engineModelInfo = (Engine)enginesInfo.Find(e => e.EngineModel == engineModelName);
            Car currenCar=new Car(carModel,engineModelInfo);
            if (inputData.Length == 3)
            {
                var weightOrColor = inputData[2];
                if (weightOrColor.ToCharArray().Any(c => char.IsLetter(c)))
                {
                    currenCar.ColorCar = weightOrColor;
                }
                else
                {
                    currenCar.WeightCar = weightOrColor;
                }
            }
            else if (inputData.Length == 4)
            {
                currenCar.WeightCar = inputData[2];
                currenCar.ColorCar = inputData[3];
            }
            carsInfo.Add(currenCar);
        }
        return carsInfo;
    }


    private static List<Engine> GetEnginesInfo()
    {
        List<Engine> enginesInfo =new List<Engine>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            string[] inputData = Console.ReadLine().Trim().Split();
            string engineModel = inputData[0];
            double enginePower = double.Parse(inputData[1]);
            Engine currentEngine=new Engine(engineModel,enginePower);
            if (inputData.Length==3)
            {
                var displacementOrEfficiency = inputData[2];
                if (displacementOrEfficiency.ToCharArray().Any(c=>char.IsLetter(c)))
                {
                    currentEngine.EngineEfficiency = displacementOrEfficiency;
                }
                else
                {
                    currentEngine.EngineDisplacement = displacementOrEfficiency;
                }
            }
            else if (inputData.Length == 4)
            {
                currentEngine.EngineDisplacement = inputData[2];
                currentEngine.EngineEfficiency = inputData[3];
            }
            enginesInfo.Add(currentEngine);
        }
        return enginesInfo;
    }
}

