using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            int opcion = 0;

            while (opcion < 10)
            {
                Console.WriteLine("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                listaNumeros.Add(numero);
                opcion++;
            }

            int numeroMayor = listaNumeros.Max();
            int numeroMenor = listaNumeros.Min();
            Console.WriteLine("El numero mayor es: " + numeroMayor);
            Console.WriteLine("El numero menor es: " + numeroMenor);
            Console.ReadLine();
        }
    }
}
