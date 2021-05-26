using System;
using System.Globalization;

namespace aula_construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do Produto
            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            int qtde_prod = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, qtde_prod);

            Console.WriteLine("Dados do Produto: " + p);

            //Adicionando qtde ao produto
            Console.WriteLine();
            Console.Write("Informe a quantidade de prdutos e ser adicionado: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtde);
            Console.WriteLine("Dados do Produto: " + p);

            //Remove qtde ao produto
            Console.WriteLine();
            Console.Write("Informe a quantidade de prdutos e ser removido: ");
            int qtde_rem = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtde_rem);
            Console.WriteLine("Dados do Produto: " + p);
        }
    }
}
