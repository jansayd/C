using System;
using System.Globalization;

namespace exercicio_classes_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno:");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a.CalculaNotaFinal();

            Console.WriteLine($"Nota Final: {a.NFinal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(a.VerificaSituacaoFinal());
        }
    }
}
