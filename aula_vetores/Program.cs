using System;
using System.Globalization;

namespace aula_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de alturas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            double media = 0;

            for (int x = 0; x < n; x++)
            {
                Console.Write("Informe a " + x.ToString() + "ª altura: ");
                vet[x] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media = media + vet[x];
            }

            Console.Write("A média de altura é: " + (media / n).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
