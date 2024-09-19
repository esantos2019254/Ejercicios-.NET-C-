using System;

namespace Ejercicio_4
{
    class Vehiculo
    {
        public int Ruedas { get; set; }

        private int Puertas { get; set; }

        public Vehiculo()
        {
            Ruedas = 4;
            Puertas = 4;
        }

        public Vehiculo(int ruedas)
        {
            Ruedas = ruedas;
            Puertas = 4;
        }

        public Vehiculo(int ruedas, int puertas)
        {
            Ruedas = ruedas;
            Puertas = puertas;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Vehículo con {Ruedas} ruedas y {Puertas} puertas.");
        }

        public int ObtenerPuertas()
        {
            return Puertas;
        }

        public void EstablecerPuertas(int puertas)
        {
            Puertas = puertas;
        }
    }
}
