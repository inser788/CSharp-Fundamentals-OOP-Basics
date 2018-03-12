using System.Collections.Generic;

public class Garage
{
    public List<int> ParkedCars { get; set; }

    public Garage()
    {
        this.ParkedCars=new List<int>();
    }

    public void AddCar(int id)
    {
        ParkedCars.Add(id);
    }

    public void RemoveCar(int id)
    {
        ParkedCars.Remove(id);
    }
}

