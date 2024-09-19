using System;

namespace Ejercicio_1
{
    public class Animal : IAnimal
    {
        public string Tipo { get; set; }
        public void Caminar()
        {
            Console.WriteLine("El animal está andando.");
        }

        public bool EsPerro()
        {
            return Tipo.ToLower() == "perro";
        }

        public void Saltar()
        {
            Console.WriteLine("El animal está saltando.");
        }
    }
}
