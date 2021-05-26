using System;

namespace exercicio_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o numero de Linhas: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Informe o numero de Colunas: ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("Linhas: " + mat.GetLength(0) + " COlunas: " + mat.GetLength(1));
        }
    }
}
