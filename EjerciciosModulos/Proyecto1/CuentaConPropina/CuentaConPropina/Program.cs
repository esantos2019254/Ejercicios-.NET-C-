using System;

namespace CuentaConPropina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el total a pagar de su cuenta.");
            float totalCuenta = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el % de propina que desea agregar a la cuenta.");
            float porcentaje = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de personas que participaran en el pago.");
            int numPersonas = int.Parse(Console.ReadLine());

            float totalPagar = TotalPagar(totalCuenta, porcentaje);
            float numeroPersona = NumeroPersona(totalPagar, numPersonas);

            Console.WriteLine(numeroPersona);

            Console.Read();
        }
        static float TotalPagar(float totalCuenta, float porcentaje)
        {
            porcentaje /= 100;
            float propina = totalCuenta * porcentaje;
            float total = totalCuenta + propina;
            return total;
        }
        static float NumeroPersona(float total, int numPersonas)
        {
            float montoPagarPersona = (float)Math.Round(total / numPersonas, 2);
            return montoPagarPersona;
        }

    }
}
