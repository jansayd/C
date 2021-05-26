using System;
using System.Globalization;

namespace exercicio_vetor_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a qtde de produto: ");
            int qtde = int.Parse(Console.ReadLine());
            
            Produto[] vet = new Produto[qtde];
            double media = 0;

            for (int x = 0; x < qtde; x++)
            {
                Console.Write("Informe o Produto " + x + ": ");
                string nome = Console.ReadLine();
                Console.Write("Informe o preço do Produto " + x + ": ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[x] = new Produto { Nome = nome, Preco = preco };
                media = media + preco;
            }

            Console.WriteLine("Lista dos Produtos");

            for (int w = 0; w < vet.Length; w++)
            {
                Console.WriteLine(vet[w].Nome);
            }

            Console.Write("O valor médio dos produtos é: " + (media / qtde).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
