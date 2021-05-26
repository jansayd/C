using System;

namespace aula_entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            string[] vet = v.Split(' ');
                       
            for(int c = 0; c < vet.Length; c++)
            {
                Console.WriteLine($"Posição {c} é "+vet[c]);
            }
        }
    }
}
