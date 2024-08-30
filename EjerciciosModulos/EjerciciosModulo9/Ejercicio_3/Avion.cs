using System;

namespace Ejercicio_3
{
    class Avion : Vehiculo
    {
        public Avion(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void Acelerar()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} Estoy acelerando en el cielo.");
        }
        public override void Frenar()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} Esoy frenando en el cielo.");
        }
    }
}
