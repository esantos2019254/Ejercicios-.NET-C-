using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos elementos tendrá el array?");
            int cantidad = int.Parse(Console.ReadLine());

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese el valor para la posición {i}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            MostrarArray(numeros);

            Console.WriteLine("Ingrese el nuevo valor que desea agregar");
            int nuevoValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el indice en donde desea agregar su valor");
            int indice = int.Parse(Console.ReadLine());
            if (indice > numeros.Length)
            {
                Console.WriteLine("Este indice no existe");
            } else
            {
                numeros[indice] = nuevoValor;
            }

            MostrarArray(numeros);
            Console.Read();
        }

        static void MostrarArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
