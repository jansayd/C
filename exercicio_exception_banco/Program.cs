using exercicio_exception_banco.Entities;
using exercicio_exception_banco.Entities.Exceptions;
using System;
using System.Globalization;

namespace exercicio_exception_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Account Data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialbalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account ac = new Account(number, holder, initialbalance, withdrawlimit);

                Console.WriteLine();

                Console.Write("Enter Amount for Withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ac.Withdraw(amount);

                Console.WriteLine(ac);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error Account: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error Format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Exception: " + e.Message);
            }
        }
    }
}
