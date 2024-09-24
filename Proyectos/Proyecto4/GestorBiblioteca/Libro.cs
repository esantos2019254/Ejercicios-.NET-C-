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
                Console.WriteLine($"El titulo {Titulo} del autor: {Autor} a sido prestado.");
            }else
            {
                Console.WriteLine($"El titulo {Titulo} del autor: {Autor} no esta disponible.");
            }
        }
        public override void Devolver()
        {
            base.Devolver();
            Console.WriteLine($"El titulo {Titulo} del autor: {Autor} a sido devuelto.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {Titulo} => Autor: {Autor}");
        }
    }
}
