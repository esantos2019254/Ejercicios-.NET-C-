using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona: {i + 1}");
                string nombre = Console.ReadLine();

                Console.WriteLine($"Ingrese la edad de la persona: {nombre}");
                int edad = int.Parse(Console.ReadLine());

                personas.Add(new Persona(nombre, edad));
            }

            Console.WriteLine("Persona mayores de edad: ");
            MostrarDatos(personas);
            Console.Read();
        }

        static void MostrarDatos (List<Persona> personas)
        {
            foreach(Persona datos in personas)
            {
                if (datos.Edad >= 18)
                {
                    Console.WriteLine($"Nombre: {datos.Nombre} Edad: {datos.Edad}");
                }
            }
        }
    }
}
