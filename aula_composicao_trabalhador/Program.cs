using aula_composicao_trabalhador.Entities;
using aula_composicao_trabalhador.Entities.Enums;
using System;
using System.Globalization;

namespace aula_composicao_trabalhador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker name: ");
            string workerName = Console.ReadLine();
            Console.WriteLine("Level (Junior/Pleno/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(workerName, level, baseSalary, dept);

            Console.WriteLine("How Many Contracts to this Worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHours, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine($"Income for ({month}/{year}): " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
