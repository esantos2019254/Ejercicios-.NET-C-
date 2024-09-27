using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBiblioteca
{
    class Biblioteca : IBiblioteca
    {
        List<Material> materiales = new List<Material>();
        public void AgregarMaterial(Material material)
        {
            materiales.Add(material);
        }

        public List<Material> MostrarMateriales()
        {
            return materiales;
        }

        public List<Material> BuscarPorTitulo(string titulo)
        {
            List<Material> resultado = materiales.Where(x => x.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return resultado;
        }

        public void DevolverMaterial(Material material)
        {
            material.Devolver();
        }

        public void PrestarMaterial(Material material)
        {
            material.Prestar();
        }
    }
}
