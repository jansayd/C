using aula_execption_reservas.Entities;
using aula_execption_reservas.Entities.Exceptions;
using System;

namespace aula_execption_reservas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update reservation: ");
                Console.Write("Check-in date: ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Exception: " + e.Message);
            }
        }
    }
}

