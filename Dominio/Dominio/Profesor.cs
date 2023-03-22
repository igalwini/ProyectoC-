using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Profesor:Persona
    {
        public override string saludar()
        {
            return "hola soy el profesor "+ this.Nombre;
        }
    }
}
