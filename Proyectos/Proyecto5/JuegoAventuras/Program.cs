using System;
using System.IO;

namespace JuegoAventuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = null;
            bool salirDelJuego = false;

            while (!salirDelJuego)
            {
                string nombre = "";
                string archivo = "";
                Console.WriteLine("Bienvenido, Ingrese un opción.");
                Console.WriteLine("1. Crear un nuevo jugador.");
                Console.WriteLine("2. Cargar datos del jugador.");
                Console.WriteLine("3. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        bool nombreValido = false;
                        do
                        {
                            Console.WriteLine("Ingrese su nombre de usario para su jugador.");
                            nombre = Console.ReadLine().ToLower();
                            archivo = $"{nombre}.txt";

                            if (File.Exists(archivo))
                            {
                                Console.WriteLine("Este nombre ya existe, ingrese otro.");
                            }
                            else
                            {
                                nombreValido = true;
                                jugador = new Jugador(nombre);
                                jugador.Guardar(archivo);
                                Console.WriteLine("Jugador creado exitosamente!!");
                                Jugar(jugador, archivo);
                            }
                        } while (!nombreValido);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese su nombre");
                        nombre = Console.ReadLine().ToLower();
                        archivo = $"{nombre}.txt";
                        if (!File.Exists(archivo))
                        {
                            Console.WriteLine("Este jugador no existe.");
                        }
                        else
                        {
                            jugador = new Jugador();
                            Jugador j = jugador.Cargar(archivo);
                            j.InformacionJugador();
                            Jugar(j, archivo);
                        }
                        break;
                    case 3:
                        salirDelJuego = true;
                        Console.WriteLine("Saliendo....");
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
        static void Jugar(Jugador jugador, string archivo)
        {
            bool salirDelSubmenu = false;
            do
            {
                Random random = new Random();
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine("1. Jugar");
                Console.WriteLine("2. Guardar progreso.");
                Console.WriteLine("3. Regresar.");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        bool menu = false;
                        jugador.InformacionJugador();
                        do
                        {
                            Console.WriteLine("Ingresa el numero en pantalla si fallas pierdes. Suerte!!");
                            int numeroCorrecto = random.Next(1, 100);
                            Console.WriteLine($"Numero a ingresar: {numeroCorrecto}");
                            int numeroIngresado = int.Parse(Console.ReadLine());

                            if (numeroCorrecto == numeroIngresado)
                            {
                                jugador.GanarBatalla();
                                Console.WriteLine($"Has pasado al nivel: {jugador.Nivel}");
                                menu = true;
                            }
                            else
                            {
                                jugador.PerderBatalla();
                                if (jugador.Vidas == 0)
                                {
                                    jugador.Reiniciar();
                                    menu = true;
                                }
                            }
                        } while (!menu);
                        break;
                    case 2:
                        jugador.InformacionJugador();
                        jugador.Guardar(archivo);
                        break;
                    case 3:
                        salirDelSubmenu = true;
                        Console.WriteLine("Regresando al inicio....");
                        break;
                    default:
                        break;
                }
            } while (!salirDelSubmenu);
        }
    }
}