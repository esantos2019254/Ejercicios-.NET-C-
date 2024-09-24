using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBiblioteca
{
    class Revista : Material
    {
        public string Edicion;

        public Revista (string edicion, string titulo) : base (titulo)
        {
            Edicion = edicion;
        }

        public override void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($"El {Titulo} de edicion: {Edicion} a sido prestado.");
            }else
            {
                Console.WriteLine($"El {Titulo} de edicion: {Edicion} no esta disponible.");
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {Titulo} => Edición: {Edicion}");
        }
    }
}
