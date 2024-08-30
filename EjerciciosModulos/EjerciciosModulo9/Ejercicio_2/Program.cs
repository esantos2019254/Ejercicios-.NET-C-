using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona No.{i + 1}");
                string nombre = Console.ReadLine();

                Console.WriteLine($"Ingrese la edad de {nombre}");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Es alumno o es profesor? ingresar A para alumno P para profesor.");
                string opcion = Console.ReadLine();

                if (opcion.ToLower().Equals("a"))
                {
                    Console.WriteLine("Ingrese su número de alumno: ");
                    int numeroAlumno = int.Parse(Console.ReadLine());
                    personas.Add(new Alumno(nombre, edad, numeroAlumno));
                }else if(opcion.ToLower().Equals("p"))
                {
                    Console.WriteLine("Ingrese la materia que imparte: ");
                    string materia = Console.ReadLine();
                    personas.Add(new Profesor(nombre, edad, materia));
                }else
                {
                    Console.WriteLine("Opcion invalida intentelo de nuevo. ");
                    i--;
                }
            }

            MostrarDatos(personas);
            Console.Read();
        }
        static void MostrarDatos(List<Persona> personas)
        {
            foreach (Persona datos in personas)
            {
                Console.WriteLine($"Nombre: {datos.Nombre} Edad: {datos.Edad}");
            }
        }
    }
}
