using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Persona
    {
        public int NumeroEstudiante { get; set; } 
        public string Nombre { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Persona persona &&
                   NumeroEstudiante == persona.NumeroEstudiante;
        }

        public virtual string saludar()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
        {
            return "hola "+ this.Nombre;
        }

    }
}
