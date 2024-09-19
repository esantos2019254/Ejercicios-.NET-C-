using System;

namespace Ejercicio_3
{
    class Barco : Vehiculo
    {
        public Barco(string marca, string modelo) : base(marca, modelo)
        {

        }
        public override void Acelerar()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} Estoy acelerando en el mar.");
        }
        public override void Frenar()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} Esoy frenando en el mar.");
        }
    }
}
