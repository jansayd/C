using System;
using System.Collections.Generic;
using System.Text;
using aula_execption_reservas.Entities.Exceptions;

namespace aula_execption_reservas.Entities
{
    class Reservation
    {
        public int RoomMumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomMumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro na reserva: Check-out menor que check-in");
            }

            RoomMumber = roomMumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                throw new DomainException("Erro na reserva: Data de Entrada e Data de Saida tem que ser maior que data atual");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Erro na reserva: Check-out menor que check-in");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room " + RoomMumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " + CheckOut.ToString("dd/MM/yyyy") + " nights: " + Duration();
        }
    }
}
