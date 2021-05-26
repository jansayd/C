using System;
using System.Globalization;

namespace exercicio_classes_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            //Criação do Produto
            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Qtde = int.Parse(Console.ReadLine());
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
