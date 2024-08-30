using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Alumno : Persona
    {   
        public int NumeroAlumno { get; set; }
        public Alumno(string nombre, int edad, int numeroAlumno) : base(nombre, edad)
        {
            NumeroAlumno = numeroAlumno;
        }
    } 
}
