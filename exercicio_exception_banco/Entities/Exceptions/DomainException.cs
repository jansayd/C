using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_exception_banco.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
