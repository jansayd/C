using System;
using System.Globalization;

namespace aula_entrada_de_dados_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(n1);
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine(n2);

            string[] dados = Console.ReadLine().Split(' ');

            for (int i = 0; i < dados.Length; i++)
            {
                if (i == 0) //Nome
                {
                    Console.WriteLine(dados[i]);
                } else if (i == 1) //Idade
                {
                    Console.WriteLine(int.Parse(dados[i]));
                } else if (i == 2) //valor
                {
                    Console.WriteLine(double.Parse(dados[i], CultureInfo.InvariantCulture));
                } else
                {
                    Console.WriteLine(dados[i]);
                }
            }

        }
    }
}
