using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char letra = 'Z'; letra >= 'A'; letra--)
            {
                Console.Write(letra + " ");
            }
            Console.ReadLine();
        }
    }
}
