using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacenadora<string> almacenador = new Almacenadora<string>();

            while (true)
            {
                Console.Write("Introduce un valor (o escribe 'salir' para terminar): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "salir")
                {
                    break;
                }
                almacenador.AñadirElemento(input);
            }
            almacenador.MostrarElementos();
            Console.Read();
        }
    }
}
