using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace JuegoAventuras
{
    [Serializable]
    class Jugador
    {
        public string Nombre;
        public int Nivel;
        public int Vidas;
        public int Muertes;
        public Jugador()
        {

        }
        public Jugador (string nombre)
        {
            Nombre = nombre;
            Nivel = 1;
            Vidas = 3;
            Muertes = 0;
        }

        public void InformacionJugador()
        {
            Console.WriteLine($"\nNombre: {Nombre} Nivel: {Nivel} Vidas: {Vidas} Muertes: {Muertes}\n");
        }

        public void GanarBatalla()
        {
            Console.WriteLine("Has ganado la batalla!!!!");
            SubirNivel();
        }

        public void SubirNivel()
        {
            Nivel++;
            Vidas = 3;
            Muertes = 0;
        }

        public void PerderBatalla()
        {
            Console.WriteLine("\nHas perdido la batalla :(");
            Vidas--;
            Muertes++;
            if(Vidas == 0)
            {
                Console.WriteLine("Fin del juego. Intentalo de nuevo.\n");
            }else
            {
                Console.WriteLine($"\nTe Quedan {Vidas} Vidas.  Muertes: {Muertes}\n");
            }
        }
        public void Reiniciar()
        {
            Vidas = 3;
            Muertes = 0;
        }
        public void Guardar(string rutaArchivo)
        {
            try
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, this);
                    Console.WriteLine("Datos del jugador guardados correctamente.");
                }
            }
            catch (Exception e)
            {
                RegistrarError(e);
                Console.WriteLine("Ocurrio un error al guardar los datos.");
            }
        }

        public Jugador Cargar (String rutaArchivo)
        {
            try
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Jugador jugador = (Jugador)formatter.Deserialize(fs);
                    return jugador;
                }
            }
            catch (Exception e)
            {
                RegistrarError(e);
                Console.WriteLine("Ocurrio un error al cargar los datos.");
                return null;
            }
        }

        public static void RegistrarError(Exception e)
        {
            string rutaLog = "logErrores.txt";

            using(StreamWriter sw = new StreamWriter(rutaLog, true))
            {
                sw.WriteLine($"{DateTime.Now}: {e.Message}");
            }
        }
    }
}