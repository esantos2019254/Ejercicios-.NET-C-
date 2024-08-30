using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche("Toyota", "Corolla");
            Barco miBarco = new Barco("Yamaha", "FX Cruiser");
            Avion miAvion = new Avion("Boeing", "747");

            miCoche.Acelerar();
            miCoche.Frenar();
            Console.WriteLine();

            miBarco.Acelerar();
            miBarco.Frenar();
            Console.WriteLine();

            miAvion.Acelerar();
            miAvion.Frenar();
            Console.ReadLine();
        }
    }
}
