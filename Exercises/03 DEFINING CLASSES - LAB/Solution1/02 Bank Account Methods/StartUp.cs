using System;

class StartUp
{
    static void Main()
    {
        BankAccount acc=new BankAccount();
        acc.Id = 1;
        acc.Balance = 100;
        acc.Deposit(20);
        acc.Withdraw(300);
        Console.WriteLine(acc);
    }
}

