using exercicio_proposto_linq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace exercicio_proposto_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path: ");
            string path = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double sal = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, sal));
                }
            }

            var salaryHigh = list.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("E-mail of people whose salary is more than " + salary.ToString("F2"));
            foreach (string sal in salaryHigh)
            {
                Console.WriteLine(sal);
            }

            var salaryM = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary od people whose name starts with 'M': " + salaryM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
