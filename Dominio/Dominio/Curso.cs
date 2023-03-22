using Dominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Curso : ICurso
    {
        public string Nombre { get; set; }  
        public List<Persona> Personas { get; set; }=new List<Persona>();

        
        public void AgregarPersona(Persona p)
        {
            if (Personas.Count>0 && Personas.Contains(p)){
            throw new PersonaRepetidaException("La persona ya está en el curso");
            } else
            {
            if (Personas.Count >= 3)
            {
                throw new CursoLlenoException("El curso ya está lleno");
            }
            else { Personas.Add(p); }
            }
        }


    }
}
