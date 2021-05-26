using aula_heranca.Entities;
using System;

namespace aula_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Guilherme", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Google", 0.0, 1000.00);

            //Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //Downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);
            BusinessAccount acc5 = (BusinessAccount)acc3;
        }
    }
}
