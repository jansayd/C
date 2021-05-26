using System;
using System.Globalization;

namespace exercicio_entrada_de_dados_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem an sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("QUal é o preço de sua casa? ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha): ");
            string [] dados = Console.ReadLine().Split(' ');

            Console.WriteLine("-------------------IMPRESSÂO-------------------");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Qtde quartos: {quartos}");
            Console.WriteLine($"Preço da casa: {preco}");
            Console.WriteLine($"Ultimo Nome: {dados[0]}");
            Console.WriteLine($"Ultima Idade: {int.Parse(dados[1])}");
            Console.WriteLine($"Ultima Altura: {double.Parse(dados[2], CultureInfo.InvariantCulture)}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
