using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Ingredientes
    {
        private string Nombre { get; set; }
        private int Cantidad { get; set; }

        public Ingredientes (string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }
}
