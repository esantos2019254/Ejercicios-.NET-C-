using System;


namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            if (nombre.Equals("Alejandro", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hola Alejandro");
            }else
            {
                Console.WriteLine("No te conozco");
            }
            Console.ReadLine();
        }
    }
}