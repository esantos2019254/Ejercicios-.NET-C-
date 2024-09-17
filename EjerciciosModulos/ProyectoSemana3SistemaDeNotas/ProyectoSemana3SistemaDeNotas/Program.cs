using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana3SistemaDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.setNombre("Juan");
            alumno1.setApellido("Perez");
            alumno1.setNumIdentificacion("0001");
            alumno1.AgregarNota(59);
            alumno1.AgregarNota(89.45);
            alumno1.AgregarNota(83.3);
            alumno1.AgregarNota(43);

            Alumno alumno2 = new Alumno("Elmer", "Santos", "0002", "Informatica", new List<double> { 80, 60.4, 70, 65 });

            Alumno alumno3 = new Alumno("Rodrigo", "García", "0003", "Ciencias", 80, 23.45, 92.34, 79);
        }
    }
}
