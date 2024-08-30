using System;
using System.Collections.Generic;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            int opcion = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            while (opcion < 10)
            {
                Console.WriteLine("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                listaNumeros.Add(numero);
                opcion++;
            }

            foreach (int num in listaNumeros)
            {
                if (num % 2 == 0)
                {
                    sumaPares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }

            Console.WriteLine("La suma de los números pares es: " + sumaPares);
            Console.WriteLine("La suma de los números impares es: " + sumaImpares);
            Console.ReadLine();
        }
    }
}
