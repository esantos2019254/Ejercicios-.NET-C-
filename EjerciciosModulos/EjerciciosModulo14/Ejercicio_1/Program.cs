using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Receta tortillaDePatatas = new Receta();
            tortillaDePatatas.AgregarIngredientes("Papas",8);
            tortillaDePatatas.AgregarIngredientes("Cebolla", 1);
            tortillaDePatatas.AgregarIngredientes("Huevos", 4);
            tortillaDePatatas.AgregarIngredientes("Aceite", 1);

            Console.WriteLine("Iniciando con la preparación de la tortilla...");

            await tortillaDePatatas.Preparar();

            Console.WriteLine("Tortilla Prepara!!!!");
            Console.ReadLine();
        }
    }
}
