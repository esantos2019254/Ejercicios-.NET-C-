using System;
using System.Collections.Generic;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> mapaAnimales = new Dictionary<int, string>
        {
            { (int)Animales.Perro, Animales.Perro.ToString() },
            { (int)Animales.Gato, Animales.Gato.ToString() },
            { (int)Animales.Canario, Animales.Canario.ToString() },
            { (int)Animales.Caballo, Animales.Caballo.ToString() }
        };

            Console.Write("Introduce un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (mapaAnimales.ContainsKey(numero))
            {
                Console.WriteLine($"Ese valor pertenece al {mapaAnimales[numero]}");
            }
            else
            {
                Console.WriteLine("No hay ningún animal con ese valor.");
            }
            Console.Read();
        }
    }
}
