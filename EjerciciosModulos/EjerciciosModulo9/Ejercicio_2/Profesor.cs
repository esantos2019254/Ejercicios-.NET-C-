using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Profesor : Persona
    {
        public string Materia { get; set; }
        public Profesor(string nombre, int edad, string materia) : base(nombre, edad)
        {
            Materia = materia;
        }
    }
}
