using System;
using System.Collections.Generic;
using System.Text;

namespace aula_heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimite) : base(number, holder, balance)
        {
            LoanLimit = loanLimite;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }            
        }
    }
}
