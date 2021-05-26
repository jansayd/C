using System;

namespace exercicio_matriz_posicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero de Linhas da Matriz: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Numero de Colunas da Matriz: ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("----------------------Impressão da Matriz-----------------------------");
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("");
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Digite o valor a ser pesquisado: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------Posiçoes do Valor Escolhido-----------------------------");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == valor)
                    {
                        Console.WriteLine($"Posição {i},{j} ");
                        if ((j + 1) < mat.GetLength(1))
                        {
                            Console.WriteLine($"Direita: " + mat[i, j + 1]);
                        }
                        if ((j - 1) >= 0)
                        {
                            Console.WriteLine($"Esquerda: " + mat[i, j - 1]);
                        }
                        if ((i - 1) >= 0)
                        {
                            Console.WriteLine($"Acima: " + mat[i -1, j]);
                        }
                        if ((i + 1) < mat.GetLength(0))
                        {
                            Console.WriteLine($"Abaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine("----------------------");
                    }                    
                }
            }
        }
    }
}
