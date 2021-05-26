using exercicio_abstract_herencas.Entities;
using exercicio_abstract_herencas.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio_abstract_herencas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle ou Circle(r/c): ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (c == 'r')
                {
                    Console.Write("Width: ");
                    double w = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(w, h, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(r, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------SHAPE AREAS----------");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
