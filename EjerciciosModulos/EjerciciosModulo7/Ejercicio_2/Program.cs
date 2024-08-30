using System;
using System.Collections.Generic;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaNombres = new List<string>();
            int opcion = 0;
            string nombre;

            while (opcion < 5)
            {
                Console.WriteLine("Ingrese un nombre: ");
                nombre = Console.ReadLine();

                if (listaNombres.Contains(nombre))
                {
                    Console.WriteLine("Este nombre ya existe en la lista, ingrese otro.");
                }
                else
                {
                    listaNombres.Add(nombre);
                    opcion++;
                }
            }

            Console.WriteLine("Ingrese un nombre para buscar en la lista: ");
            string nombreBuscar = Console.ReadLine();

            if (listaNombres.Contains(nombreBuscar))
            {
                Console.WriteLine($"El nombre '{nombreBuscar}' está en la lista.");
            }
            else
            {
                Console.WriteLine($"El nombre '{nombreBuscar}' no está en la lista.");
            }
            Console.ReadLine();
        }
    }
}
