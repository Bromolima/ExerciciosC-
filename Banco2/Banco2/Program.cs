using Banco2.Entities;
using Banco2.Entities.Exceptions;
using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account a = new Account(number, name, balance, withDrawLimit);
                Console.WriteLine(a);

                Console.Write("Enter the amout for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                a.Withdraw(amount);
                Console.WriteLine(a);

            } catch (DomainException e) {
                Console.WriteLine("Error in creating bank account: " + e.Message);
            }
         }
    }
}