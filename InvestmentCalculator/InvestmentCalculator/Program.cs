using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestmentCalculator;

namespace InvestmentCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nominal;
            decimal price;
            TransactionType transactionType;
            decimal currentValue;

            Console.Write("Input the nominal value");
            string userInput = Console.ReadLine();
            nominal = int.Parse(userInput);

            Console.Write("Input the price: ");
            userInput = Console.ReadLine();
            price = decimal.Parse(userInput);

            Console.Write("Input the transaction type: ");
            userInput = Console.ReadLine();
            transactionType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            int sign = transactionType == TransactionType.Buy ? 1 : -1;
            currentValue = sign * nominal * price;

            Console.WriteLine($"Transaction type: {transactionType}");
            Console.WriteLine($"Nominal: {nominal}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Current value (CV) = {currentValue}");

            Console.ReadKey();
        }
    }
}
