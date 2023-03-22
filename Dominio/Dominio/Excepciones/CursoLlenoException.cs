using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Excepciones
{
    internal class CursoLlenoException : Exception
    {
        public CursoLlenoException(string message) : base(message)
        {
        }
    }
}
