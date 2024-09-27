using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBiblioteca
{
    public abstract class Material
    {
        public string Titulo;
        public bool Disponible;

        public Material (string titulo)
        {
            Titulo = titulo;
            Disponible = true;
        }

        public abstract void Prestar();
        public abstract void Devolver();
    }
}
