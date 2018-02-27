using System;

public class StartUp
{
    static void Main()
    {
        string[] inputDataStudent = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string[] inputDataWorker = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        try
        {
            Student student = new Student(inputDataStudent[0],
                inputDataStudent[1],
                inputDataStudent[2]);
            Worker worker = new Worker(inputDataWorker[0],
                inputDataWorker[1],
                decimal.Parse(inputDataWorker[2]),
                decimal.Parse(inputDataWorker[3]));
            Console.WriteLine(student + Environment.NewLine);
            Console.WriteLine(worker.ToString());
        }
        catch (ArgumentException argExeption)
        {
            Console.WriteLine(argExeption.Message);
        }
    }
}


