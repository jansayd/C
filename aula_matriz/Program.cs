using System;

namespace aula_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[4, 6];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0)); //qtde linhas
            Console.WriteLine(mat.GetLength(1)); //qtde colunas
            Console.Write("Matriz");
        }
    }
}
