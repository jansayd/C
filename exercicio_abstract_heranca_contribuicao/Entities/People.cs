using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstract_heranca_contribuicao.Entities
{
    abstract class People
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected People(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    }
}
