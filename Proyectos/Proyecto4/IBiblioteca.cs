﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBiblioteca
{
    public interface IBiblioteca
    {
        void AgregarMaterial(Material material);
        List<Material> BuscarPorTitulo(string titulo);
        void PrestarMaterial(Material material);
        void DevolverMaterial(Material material);
    }
}
