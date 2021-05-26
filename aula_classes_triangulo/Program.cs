using System;
using System.Globalization;

namespace aula_classes_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando X e Y do tipo Obj Triangulo
            Triangulo x, y;
            x = new Triangulo(); //Instanciando os objs de triangulo
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalculaAreaTriangulo();

            double areaY = y.CalculaAreaTriangulo();

            Console.WriteLine($"A área do triangulo X é: {areaX.ToString("F4")}");
            Console.WriteLine($"A área do traingulo Y é: {areaY.ToString("F4")}");
        }
    }
}
