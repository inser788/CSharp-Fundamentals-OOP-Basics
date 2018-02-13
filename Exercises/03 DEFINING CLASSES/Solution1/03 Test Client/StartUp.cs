using System;
using System.Collections.Generic;


class StartUp
{
    public static Dictionary<int, BankAccount> accountsDataBase;

    public static void Main(string[] args)
    {
        accountsDataBase = new Dictionary<int, BankAccount>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
                break;
            string[] tokens = input.Split();
            string command = tokens[0];
            switch (command)
            {
                case "Create":
                    GetCreate(tokens, accountsDataBase);
                    break;
                case "Deposit":
                    GetDeposit(tokens, accountsDataBase);
                    break;
                case "Withdraw":
                    GetWithdraw(tokens, accountsDataBase);
                    break;
                case "Print":
                    GetPrint(tokens, accountsDataBase);
                    break;
            }
        }
    }

    public static void GetPrint(string[] tokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int idAccount = int.Parse(tokens[1]);
        if (!accountsDataBase.ContainsKey(idAccount))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        Console.WriteLine(
            $"Account ID{accountsDataBase[idAccount].Id}, balance {accountsDataBase[idAccount].Balance:f2}");
    }

    public static void GetWithdraw(string[] tokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int idAccount = int.Parse(tokens[1]);
        decimal withdrawAmount = decimal.Parse(tokens[2]);
        if (!accountsDataBase.ContainsKey(idAccount))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        if (accountsDataBase[idAccount].Balance - withdrawAmount < 0)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        accountsDataBase[idAccount].Balance -= withdrawAmount;
    }

    public static void GetDeposit(string[] tokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int idAccount = int.Parse(tokens[1]);
        decimal depositAmount = decimal.Parse(tokens[2]);
        if (!accountsDataBase.ContainsKey(idAccount))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        accountsDataBase[idAccount].Balance += depositAmount;
    }

    public static void GetCreate(string[] tokens, Dictionary<int, BankAccount> bankAccounts)
    {
        int idAccount = int.Parse(tokens[1]);
        if (accountsDataBase.ContainsKey(idAccount))
        {
            Console.WriteLine("Account already exists");
            return;
        }

        var acc=new BankAccount();
        acc.Id = idAccount;
        accountsDataBase.Add(idAccount,acc);
    }
}

