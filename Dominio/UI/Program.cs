using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona e1 = new Estudiante()
            {
                NumeroEstudiante = 1,
                Nombre = "Ernesto"
            };
            Persona e2 = new Estudiante()
            {
                NumeroEstudiante = 2,
                Nombre = "Igal"
            };
            Persona e3 = new Estudiante()
            {
                NumeroEstudiante = 3,
                Nombre = "Juan"
            };
            Persona p1 = new Profesor()
            {
                NumeroEstudiante = 4,
                Nombre = "Igal"
            };
            Curso c1 = new Curso()
            {
                Nombre = "Diseño 1"
            };
            c1.AgregarPersona(e2);
            c1.AgregarPersona(e1);
            c1.AgregarPersona(e3);
            foreach (Persona persona in c1.Personas) {
                Console.WriteLine(persona.saludar());
            }
            Console.ReadLine();
        }
    }
}
