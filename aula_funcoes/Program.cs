using System;

namespace aula_funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            resultado = Maior(n1, n2, n3); //chamada da função Maior

            Console.WriteLine($"O Maior número é: {resultado}");

        }

        static int Maior(int n1, int n2, int n3) //função para calcular o maior numero
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            } else if(n2 > n3){
                return n2;
            }
            else
            {
                return n3;
            }
        }
    }
}
