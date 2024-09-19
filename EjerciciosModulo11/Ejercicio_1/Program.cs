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
            // Crear un diccionario para almacenar las claves enteras y los valores string
            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            while (true)
            {
                // Pedir un número por consola
                Console.Write("Introduce un número (0 para terminar): ");
                int numero = int.Parse(Console.ReadLine());

                // Si el número es 0, salir del bucle
                if (numero == 0)
                    break;

                // Pedir una cadena por consola
                Console.Write("Introduce una cadena: ");
                string cadena = Console.ReadLine();

                // Insertar el número y la cadena en el diccionario
                diccionario[numero] = cadena;
            }

            // Pedir una cadena de 2 letras
            Console.Write("Introduce una cadena de 2 letras para buscar: ");
            string buscar = Console.ReadLine();

            // Recorrer el diccionario y mostrar las claves cuyos valores contienen la cadena de 2 letras
            Console.WriteLine("Claves cuyos valores contienen '" + buscar + "':");
            foreach (var entrada in diccionario)
            {
                if (entrada.Value.Contains(buscar))
                {
                    Console.WriteLine(entrada.Key);
                }
            }
        }
    }
}
