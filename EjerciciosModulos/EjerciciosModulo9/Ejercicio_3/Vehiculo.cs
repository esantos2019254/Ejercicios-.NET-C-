using System;

namespace Ejercicio_3
{
    class  Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void Acelerar ()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} Estoy acelerando");
        }

        public virtual void Frenar ()
        {
            Console.WriteLine($"Yo {Marca} {Modelo} Esoy frenando");
        }
    }
}
