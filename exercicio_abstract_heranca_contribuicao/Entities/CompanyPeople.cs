using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstract_heranca_contribuicao.Entities
{
    class CompanyPeople : People
    {
        public double Employee { set; get; }

        public CompanyPeople(string name, double anualIncome, double employee) : base(name, anualIncome)
        {
            Employee = employee;
        }

        public override double TaxesPaid()
        {
            double taxes_paid = 0.0;

            if (Employee >= 10)
            {
                taxes_paid = AnualIncome * 14 / 100.00;
            } else
            {
                taxes_paid = AnualIncome * 16 / 100.00;
            }
            return taxes_paid;
        }
    }
}
