using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Localidad: ");
            string localidad = Console.ReadLine();

            string cadena = $"{nombre}|{edad}|{localidad}";
            string nombreArchivo = $"{nombre}.txt";

            try
            {
                FileManager.VerificarArchivo(nombreArchivo);
                Console.WriteLine("El archivo ya existe. Escoja una opción");
                PedirDatos(nombreArchivo);
            }
            catch(FileManager.ArchivoNoEncontradoException e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    FileManager.CrearArchivo(nombreArchivo, cadena);
                    Console.WriteLine("Archivo creado correctamente.");
                    PedirDatos(nombreArchivo);
                }
                catch(FileManager.ArchivoSiExisteException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }

        static void PedirDatos(string nombreArchivo)
        {
            while (true)
            {
                Console.WriteLine("Quieres añadir más personas? (S/N):");
                string opcion = Console.ReadLine();

                if (opcion.ToLower().Equals("s"))
                {
                    Console.WriteLine("Ingrese un Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la Edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Localidad: ");
                    string localidad = Console.ReadLine();

                    string cadena = $"{nombre}|{edad}|{localidad}";

                    try
                    {
                        FileManager.AgregarTexto(nombreArchivo, cadena);
                    }
                    catch (FileManager.ArchivoNoEncontradoException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    try
                    {
                        FileManager.MostrarArchivo(nombreArchivo);
                    }
                    catch (FileManager.ArchivoNoEncontradoException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                }
            }
        }
    }
}