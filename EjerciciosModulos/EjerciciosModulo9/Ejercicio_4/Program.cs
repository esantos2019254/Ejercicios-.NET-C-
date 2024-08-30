using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo();
            vehiculo1.MostrarInformacion();

            Vehiculo vehiculo2 = new Vehiculo(2);
            vehiculo2.MostrarInformacion();

            Vehiculo vehiculo3 = new Vehiculo(6, 2);
            vehiculo3.MostrarInformacion();

            vehiculo3.EstablecerPuertas(3);
            Console.WriteLine($"El vehículo ahora tiene {vehiculo3.ObtenerPuertas()} puertas.");

            Console.ReadLine();
        }
    }
}
