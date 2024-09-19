using System;
using System.Collections;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaNumeros = new ArrayList();

            for (int i = 1; i <= 1000; i++)
            {
                listaNumeros.Add(i);
            }

            int suma = 0;
            foreach (int numero in listaNumeros)
            {
                suma += numero;
            }

            Console.WriteLine("La suma de los números del 1 al 1000 es: " + suma);
            Console.ReadLine();
        }
    }
}
