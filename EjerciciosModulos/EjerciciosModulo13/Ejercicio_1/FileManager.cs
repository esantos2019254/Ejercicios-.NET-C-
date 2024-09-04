using System;
using System.IO;
using System.Text;

namespace Ejercicio_1
{
    class FileManager
    {
        public class ArchivoNoEncontradoException : Exception
        {
            public ArchivoNoEncontradoException(string mensaje) : base(mensaje)
            {

            }
        }

        public class ArchivoSiExisteException : Exception
        {
            public ArchivoSiExisteException(string mensaje) : base(mensaje)
            {

            }
        }

        public static void VerificarArchivo(string nombreArchivo)
        {
            if (!File.Exists(nombreArchivo))
            {
                throw new ArchivoNoEncontradoException("Archivo no encontrado");
            }
        }

        public static void CrearArchivo(string nombreArchivo, string cadena)
        {
            if (File.Exists(nombreArchivo))
            {
                throw new ArchivoSiExisteException("El archivo ya existe.");
            }
            else
            {
                try
                {
                    using (FileStream fs = new FileStream(nombreArchivo, FileMode.Create))
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(cadena);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ocurrió un error: {e.Message}");
                }
            }
        }

        public static void MostrarArchivo (string nombreArchivo)
        {
            if (!File.Exists(nombreArchivo))
            {
                throw new ArchivoNoEncontradoException("Archivo no encontrado");
            }
            else
            {
                try
                {
                    using (FileStream fs = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buffer = new byte[fs.Length];

                        int bytesRead = fs.Read(buffer, 0, buffer.Length);

                        string contenido = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        Console.WriteLine("Contenido del archivo:");
                        Console.WriteLine(contenido);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ocurrió un error: {e.Message}");
                }
            }
        }

        public static void AgregarTexto(string nombreArchivo, string cadena)
        {
            if (!File.Exists(nombreArchivo))
            {
                throw new ArchivoNoEncontradoException("Archivo no encontrado");
            }
            else
            {
                try
                {
                    using (FileStream fs = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write))
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes("\n" + cadena);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ocurrió un error: {e.Message}");
                }
            }
        }
    }
}
