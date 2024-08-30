using System;
using System.Text;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int numero;
            StringBuilder frase = new StringBuilder();

            int[] numeros = new int[4];

            while (opcion < 4)
            {
                Console.Write($"Ingrese el número {opcion + 1}: ");
                numero = int.Parse(Console.ReadLine());
                numeros[opcion] = numero;
                opcion++;
            }

            frase.Append("El primer número introducido es el ");
            frase.Append(numeros[0]);
            frase.Append(", después han introducido el ");
            frase.Append(numeros[1]);
            frase.Append(" y ");
            frase.Append(numeros[2]);
            frase.Append(", y por último el ");
            frase.Append(numeros[3]);

            Console.WriteLine(frase.ToString());
            Console.ReadLine();
        }
    }
}
