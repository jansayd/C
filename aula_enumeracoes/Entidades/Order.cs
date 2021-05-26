using aula_enumeracoes.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace aula_enumeracoes.Entidades
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + " - " + Moment + " - " + Status;
        }
    }
}
