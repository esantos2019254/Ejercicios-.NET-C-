using System;


namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();

            string palabraInvertida = InvertirPalabra(palabra);

            Console.WriteLine($"La palabra invertida es: {palabraInvertida}");
            Console.ReadLine();
        }
        static string InvertirPalabra(string palabra)
        {
            char[] array = palabra.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        
    }
}
