using System;

namespace Ejercicio_3
{
    class Coche : Vehiculo
    {
        public Coche(string marca, string modelo) : base(marca, modelo)
        {

        }

        public override void Acelerar ()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} estoy acelerando en la autopista.");
        }

        public override void Frenar()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} estoy frenando en un semaforo");
        }
    }
}
