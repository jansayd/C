using System;

namespace exercicio_reserva_hotel_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarto;

            Console.Write("Informe o numero de hospedes: ");
            int hosp = int.Parse(Console.ReadLine());
            Reserva[] vet = new Reserva[10];                       

            for(int x = 0; x < hosp; x++)
            {
                Console.Write("Nome do Hospede: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail do Hospede: ");
                string email = Console.ReadLine();
                Console.Write("Numero do Quarto (0 - 9): ");
                quarto = int.Parse(Console.ReadLine());

                vet[quarto] = new Reserva { Nome = nome, Email = email, Quarto = quarto };  
            }

            Console.WriteLine("Lista de Quartos Ocupados!");
            
            for (int w = 0; w < vet.Length; w++)
            {
                if(vet[w] != null) {
                    Console.WriteLine(vet[w].Quarto.ToString() + ":" + vet[w].Nome + "," + vet[w].Email);
                }
            }
        }
    }
}
