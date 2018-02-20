using System;

class StartUp
{
    static void Main()
    {
        BankAccount acc = new BankAccount();

        acc.Id = 1;
        acc.Balance = 1.5m;

        Console.WriteLine($"Account {acc.Id} Balance {acc.Balance}");
    }
}

