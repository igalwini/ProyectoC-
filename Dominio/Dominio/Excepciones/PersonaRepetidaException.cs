using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones
{
    public class PersonaRepetidaException : Exception
    {
        public PersonaRepetidaException(string message) : base(message)
        {
        }
    }
}
