using exercicio_exception_banco.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exercicio_exception_banco.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdoraw Error: The amount Exceeds Withdraw Limits!");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdoraw Error: Not Enough Balance!");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
