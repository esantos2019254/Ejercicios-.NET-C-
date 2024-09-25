using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Gabriel García", "Cien años de soledad");
            Libro libro2 = new Libro("George Orwell", "1984");
            Libro libro3 = new Libro("Patrick Rothfuss", "El nombre del viento");

            List<Libro> listaLibros = new List<Libro> { libro1, libro2, libro3 };

            Revista revista1 = new Revista("Septiembre 2024", "The Economist");
            Revista revista2 = new Revista("Junio 2024", "Harvard Business Review");
            Revista revista3 = new Revista("Julio 2024", "Forbes");

            List<Revista> listaRevistas = new List<Revista> { revista1, revista2, revista3 };

            Console.WriteLine("----- LISTA DE LIBROS -----");
            foreach(var datos in listaLibros)
            {
                datos.MostrarInformacion();
            }

            Console.WriteLine("\n----- LISTA DE REVISTAS -----");
            foreach (var datos in listaRevistas)
            {
                datos.MostrarInformacion();
            }

            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AgregarMaterial(libro1);
            biblioteca.AgregarMaterial(libro2);
            biblioteca.AgregarMaterial(libro3);
            biblioteca.AgregarMaterial(revista1);
            biblioteca.AgregarMaterial(revista2);
            biblioteca.AgregarMaterial(revista3);

            List<Material> listaMateriales = biblioteca.MostrarMateriales();

            Console.WriteLine("\n----- LISTA DE MATERIALES -----");
            foreach (var datos in listaMateriales)
            {
                string estado = datos.Disponible ? "Disponible" : "No disponible";
                Console.WriteLine($"Titulo: {datos.Titulo} => Estado: {estado}");
            }

            Console.WriteLine("\n----- PRESTAR MATERIALES -----");
            biblioteca.PrestarMaterial(libro1);
            biblioteca.PrestarMaterial(revista2);
            biblioteca.PrestarMaterial(revista3);

            Console.WriteLine("\n----- DEVOLVER MATERIALES -----");
            biblioteca.DevolverMaterial(revista3);

            Console.WriteLine("\n----- BUSCAR MATERIALES -----");
            var material = biblioteca.BuscarPorTitulo("DE");
            if (!material.Any())
            {
                Console.WriteLine("No se encontraron materiales con ese título.");
            }
            else
            {
                foreach (var datos in material)
                {
                    Console.WriteLine($"Material encontrado: {datos.Titulo}");
                }
            }

            Console.WriteLine("\n----- PRESTAR MATERIALES -----");
            biblioteca.PrestarMaterial(libro1);

            Console.WriteLine("\n----- LISTA DE MATERIALES -----");
            foreach (var datos in listaMateriales)
            {
                string estado = datos.Disponible ? "Disponible" : "No disponible";
                Console.WriteLine($"Titulo: {datos.Titulo} => Estado: {estado}");
            }
            Console.ReadKey();
        }
    }
}
