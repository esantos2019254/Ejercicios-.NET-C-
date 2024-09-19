using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase de al menos 20 caracteres y 4 palabras");
            string frase = Console.ReadLine();

            if(frase.Length >= 20 && ContarPalabras(frase) >=4)
            {
                Console.WriteLine($"La longitud de la frase es: {frase.Length}");
                Console.WriteLine($"El resultado de reemplazar 'a' por 'x' es: {ReemplazarFrase(frase)}");
                Console.WriteLine($"Cadena en mayúsculas: {frase.ToUpper()}");
                Console.WriteLine($"Cadena en minúsculas: {frase.ToLower()}");
                Console.WriteLine($"Cadena sin las 3 primeras letras: {RemoverPrimerasTresLetras(frase)}");
                Console.WriteLine($"Subcadena de la posición 5 a 10: {ExtraerSubcadena(frase)}");
                Console.WriteLine($"Cadena invertida: {InvertirCadena(frase)}");
                Console.WriteLine($"Número de palabras: {ContarPalabras(frase)}");
                Console.WriteLine($"Tercera palabra: {ObtenerTerceraPalabra(frase)}");
            }
            else
            {
                Console.WriteLine("La palabra debe tener al menos 20 caracteres y 4 palabras");
            }

            Console.ReadLine();
        }

        static int ContarPalabras(string frase)
        {
            return frase.Split(' ').Length;
        }

        static string ReemplazarFrase(string frase)
        {
            return frase.Replace("a", "x").Replace("A", "X");
        }
        static string RemoverPrimerasTresLetras(string frase)
        {
            if (frase.Length > 3)
            {
                return frase.Substring(3);
            }
            return frase;
        }
        static string ExtraerSubcadena(string frase)
        {
            if (frase.Length >= 10)
            {
                return frase.Substring(4, 6);
            }
            return "La cadena es demasiado corta para extraer la subcadena.";
        }
        static string InvertirCadena(string frase)
        {
            char[] array = frase.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static string ObtenerTerceraPalabra(string frase)
        {
            string[] palabras = frase.Split(' ');
            if (palabras.Length >= 3)
            {
                return palabras[2];
            }
            return "No hay suficientes palabras en la frase.";
        }
    }
}
