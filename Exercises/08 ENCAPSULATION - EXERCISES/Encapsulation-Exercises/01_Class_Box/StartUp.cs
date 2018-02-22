using System;

public class StartUp
{
    static void Main()
    {
        try
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);
            box.GetSurfaceArea();
            box.GetLateralSurfaceArea();
            box.GetVolume();
            Console.WriteLine(box.ToString());
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

