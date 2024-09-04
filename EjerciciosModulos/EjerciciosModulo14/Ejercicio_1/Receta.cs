using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Receta
    {
        private List<Ingredientes> ingredientes = new List<Ingredientes>();

        public void AgregarIngredientes(string nombre, int cantidad) 
        {
            ingredientes.Add(new Ingredientes(nombre, cantidad));
        }

        public async Task Preparar()
        {
            var pelarPapasTask = PelarPapas();
            var cortarCebollaTask = CortarCebolla();
            var batirHuevos = BatirHuevos();

            await Task.WhenAll(pelarPapasTask, cortarCebollaTask, batirHuevos);

            var freirCebollaTask = Freir("Cebolla");
            var freirPapasTask = Freir("Papas");

            await Task.WhenAll(freirCebollaTask, freirPapasTask);

            await CocinarTortilla();
        }

        public async Task PelarPapas ()
        {
            Console.WriteLine("Pelando papas...");
            await Task.Delay(1500);
            Console.WriteLine("Papas peladas.");
        }

        public async Task CortarCebolla ()
        {
            Console.WriteLine("Cortando cebolla...");
            await Task.Delay(1500);
            Console.WriteLine("Cebolla cortada.");
        }

        public async Task BatirHuevos ()
        {
            Console.WriteLine("Batiendo huevos...");
            await Task.Delay(1500);
            Console.WriteLine("Huevos batidos.");
        }

        public async Task Freir (string ingrediente)
        {
            Console.WriteLine($"Friendo {ingrediente}...");
            await Task.Delay(2000);
            Console.WriteLine($"{ingrediente} fritas.");
        }

        private async Task CocinarTortilla()
        {
            Console.WriteLine("Cocinando la tortilla...");
            await Task.Delay(3000);
            Console.WriteLine("Tortilla de patatas lista.");
        }
    }
}
