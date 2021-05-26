using exercicio_herenca_polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio_herenca_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of de Employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n): ");
                char outsource = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsource == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double addit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valueperhour, addit));
                } else
                {
                    list.Add(new Employee(name, hours, valueperhour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("-----PAYMENTS-----");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
