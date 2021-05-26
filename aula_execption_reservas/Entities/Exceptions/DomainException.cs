using System;
using System.Collections.Generic;
using System.Text;

namespace aula_execption_reservas.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
