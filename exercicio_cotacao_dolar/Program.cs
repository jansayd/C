using System;
using System.Globalization;

namespace exercicio_cotacao_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do Dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos Dolares vai Comprar? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais: " + Cotacao.ConversaoDolar(cotacao, compra).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
