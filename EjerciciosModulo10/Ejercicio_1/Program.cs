using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal miAnimal = new Animal();
            miAnimal.Tipo = "Perro";

            miAnimal.Caminar();

            if (miAnimal.EsPerro())
            {
                Console.WriteLine("Este animal es un perro.");
            }
            else
            {
                Console.WriteLine("Este animal no es un perro.");
            }

            miAnimal.Saltar();
        }
    }
}
