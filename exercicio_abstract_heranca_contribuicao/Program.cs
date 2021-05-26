using exercicio_abstract_heranca_contribuicao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio_abstract_heranca_contribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();
            double total_taxes = 0;
            
            Console.WriteLine("Enter the number of tax payer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual ou Company(i/c): ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'i')
                {
                    Console.Write("Health: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualPeople(name, anualincome, health));
                } else
                {
                    Console.Write("Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new CompanyPeople(name, anualincome, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------TAXES PAID----------");
            foreach(People p in list)
            {
                Console.WriteLine(p.Name + ": $" + p.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                total_taxes += p.TaxesPaid();
            }

            Console.WriteLine();
            Console.Write("Total Taxes: $" + total_taxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
