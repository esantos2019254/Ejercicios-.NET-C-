using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Almacenadora<T>
    {
        private List<T> listado = new List<T>();
        public void AñadirElemento(T elemento)
        {
            listado.Add(elemento);
        }
        public void MostrarElementos()
        {
            Console.WriteLine("Elementos en el listado:");
            foreach (var elemento in listado)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
