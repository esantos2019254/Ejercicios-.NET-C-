using ChistesApi.Api;
using ChistesApi.Configuration;
using ChistesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChistesApi
{
    public enum Opciones
    {
        GenerarChiste = 1,
        BuscarChiste = 2,
        Salir = 3
    }

    class Program
    {
        private static ChistesApiService _apiService;
        private static ChistesService _chistesService;
        static async Task Main(string[] args)
        {
            //Acceder a la configuracion
            var configuracion = AppConfig.CargarConfiguracion();
            string apiUrl = configuracion["ApiSettings:ChisteApiUrl"];
            string rutaArchivo = configuracion["FileSettings:NameFilePath"];

            //Iniciar servicios
            _apiService = new ChistesApiService(apiUrl);
            _chistesService = new ChistesService(rutaArchivo);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("¡GENERADOR DE CHISTES!");
                Console.WriteLine("1. Obtener chiste aleatorio.");
                Console.WriteLine("2. Buscar chiste por palabra clave.");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(Opciones), opcion))
                {
                    Opciones opcionSeleccionada = (Opciones)opcion;
                    switch (opcionSeleccionada)
                    {
                        case Opciones.GenerarChiste:
                            await GenerarChiste();
                            break;
                        case Opciones.BuscarChiste:
                            BuscarChiste();
                            break;
                        case Opciones.Salir:
                            Console.WriteLine("Gracias por usar nuestra app :D ¡Hasta luego!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida, por favor ingrese un número entre 1 y 3.");
                }
            }
            Console.ReadKey();
        }

        public static async Task GenerarChiste()
        {
            string chiste = await _apiService.ObtenerChisteApi();
            bool salir = false;
            Console.WriteLine($"\n{chiste}\n");

            while (!salir)
            {
                Console.Write("¿Deseas guardarlo? (s/n): ");
                string opcion = Console.ReadLine().ToLower();

                if (opcion.Equals("s"))
                {
                    bool esChisteDuplicado = _chistesService.EsChisteDuplicado(chiste);
                    if (esChisteDuplicado)
                    {
                        Console.WriteLine("Este chiste ya esta guardado.");
                        salir = true;
                    }
                    else
                    {
                        _chistesService.GuardarChisteEnArchivo(chiste);
                        Console.WriteLine("Chiste guardado correctamente");
                        salir = true;
                    }
                }
                else if (opcion.Equals("n"))
                {
                    Console.WriteLine("Chiste NO guardado.");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Opcion no válida.");
                }
            }
        }

        public static void BuscarChiste()
        {
            Console.Write("Ingrese la palabra, letra o frase a buscar: ");
            string palabra = Console.ReadLine();
            _chistesService.BuscarChiste(palabra);
        }
    }
}