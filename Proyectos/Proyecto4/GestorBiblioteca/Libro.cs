using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBiblioteca
{
    class Libro : Material
    {
        public string Autor;

        public Libro (string autor, string titulo) : base (titulo)
        {
            Autor = autor;
        }
        public override void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($"El libro: {Titulo} del autor: {Autor} a sido prestado.");
            }else
            {
                Console.WriteLine($"El libro: {Titulo} del autor: {Autor} no esta disponible.");
            }
        }
        public override void Devolver()
        {
            Disponible = true;
            Console.WriteLine($"El libro: {Titulo} a sido devuelto.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"El libro: {Titulo} => Autor: {Autor}");
        }
    }
}
