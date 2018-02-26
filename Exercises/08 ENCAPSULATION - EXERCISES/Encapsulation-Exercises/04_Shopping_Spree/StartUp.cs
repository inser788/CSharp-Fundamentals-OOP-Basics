using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class StartUp
{
    static void Main()
    {
        try
        {
            var personsList = new List<Person>();
            var productsList = new List<Product>();

            string[] inputNamesAndMoney =
                Console.ReadLine().Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputNamesAndMoney.Length; i++)
            {
                string[] currentData =
                    inputNamesAndMoney[i].Split("=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Person currentPerson = new Person(currentData[0], double.Parse(currentData[1]));
                personsList.Add(currentPerson);
            }

            string[] inputProductsAndPrice =
                Console.ReadLine().Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputProductsAndPrice.Length; i++)
            {
                string[] currentData =
                    inputProductsAndPrice[i].Split("=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Product currentProduct = new Product(currentData[0], double.Parse(currentData[1]));
                productsList.Add(currentProduct);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;
                string[] cmdArgs = input.Split();
                if (cmdArgs.Length <= 1)
                {
                    Console.WriteLine("Name cannot be empty");
                   return;
                }

                string personName = cmdArgs[0];
                string productName = cmdArgs[1];
                if (personsList.Any(p => p.NamePerson == personName) && productsList.Any(pr => pr.Name == productName))
                {
                    var currentPerson = personsList.FirstOrDefault(p => p.NamePerson == personName);
                    var currentProduct = productsList.FirstOrDefault(pr => pr.Name == productName);
                    Console.WriteLine(currentPerson.MessageCanAddProduct(currentProduct));
                }
            }

            foreach (var person in personsList)
            {
                if (person.BagPerson.Count > 0)
                {
                    Console.WriteLine(
                        $"{person.NamePerson} - {string.Join(", ", person.BagPerson.Select(x => x.Name).ToList())}");
                }
                else
                {
                    Console.WriteLine($"{person.NamePerson} - Nothing bought");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
    }
}

