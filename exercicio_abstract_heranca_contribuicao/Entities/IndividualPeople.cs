using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstract_heranca_contribuicao.Entities
{
    class IndividualPeople : People
    {
        public double Health { get; set; }

        public IndividualPeople(string name, double anualIncome, double health) : base(name, anualIncome)
        {
            Health = health;
        }

        public override double TaxesPaid()
        {
            double taxes_paid = 0.0;

            if (AnualIncome <= 20000.00)
            {
                if (Health > 0)
                {
                    taxes_paid = (AnualIncome * 15 / 100.00) - (Health * 50 / 100.00);
                }
                else
                {
                    taxes_paid = AnualIncome * 15 / 100.00;
                }
                
            } else
            {
                if (Health > 0)
                {
                    taxes_paid = (AnualIncome * 25 / 100.00) - (Health * 50 / 100.00);
                }
                else
                {
                    taxes_paid = AnualIncome * 25 / 100.00;
                }                
            }
            return taxes_paid;
        }
    }
}
