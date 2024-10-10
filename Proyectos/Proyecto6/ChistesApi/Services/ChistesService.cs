using System;
using System.IO;
using System.Linq;

namespace ChistesApi.Services
{
    public class ChistesService
    {
        private readonly string _archivo;

        public ChistesService(string archivo)
        {
            _archivo = archivo;
        }

        public bool EsChisteDuplicado(string chiste)
        {
            if (File.Exists(_archivo))
            {
                var chistes = File.ReadAllLines(_archivo);
                return chistes.Contains(chiste);
            }
            return false;
        }

        public void GuardarChisteEnArchivo(string chiste)
        {
            using (StreamWriter sw = File.AppendText(_archivo))
            {
                sw.WriteLine(chiste);
            }
        }

        public void BuscarChiste(string palabra)
        {
            if (!File.Exists(_archivo))
            {
                Console.WriteLine("Aun no hay ningun chiste guardado.");
                return;
            }

            var chistes = File.ReadAllLines(_archivo);
            var resultados = chistes.Where(c => c.ToLower().Contains(palabra.ToLower()));

            if (resultados.Any())
            {
                Console.WriteLine("Chistes encontrados: ");
                foreach(var chiste in resultados)
                {
                    Console.WriteLine(chiste);
                }
            }
            else
            {
                Console.WriteLine("No se encontro ningun chiste con esa letra.");
            }
        }
    }
}