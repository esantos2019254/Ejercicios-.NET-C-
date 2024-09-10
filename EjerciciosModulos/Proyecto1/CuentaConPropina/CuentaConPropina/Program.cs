using System;

namespace CuentaConPropina
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            Console.WriteLine("Ingrese el total a pagar de su cuenta.");
            float totalCuenta = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el % de propina que desea agregar a la cuenta.");
            float porcentaje = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de personas que participaran en el pago.");
            int numPersonas = int.Parse(Console.ReadLine());

            float totalPagar = TotalPagar(totalCuenta, porcentaje);
            float[] pagoXPersona = PagoXPersona(totalPagar, numPersonas);

            Console.WriteLine($"El total a pagar contando propina es de: Q{totalPagar}");

            for (int i = 0; i < pagoXPersona.Length; i++)
            {
                Console.WriteLine($"La persona no.{contador} Paga: Q{pagoXPersona[i]}");
                contador++;
            }

            Console.Read();
        }
        static float TotalPagar(float totalCuenta, float porcentaje)
        {
            porcentaje /= 100;
            float propina = totalCuenta * porcentaje;
            float total = totalCuenta + propina;
            return total;
        }
        static float[] PagoXPersona(float total, int numPersonas)
        {
            float montoPagarPersona = (float)Math.Round(total / numPersonas, 2);
            float totalRedondeado = montoPagarPersona * numPersonas;
            float diferencia = total - totalRedondeado;

            float[] pagos = new float[numPersonas];

            for (int i = 0; i < numPersonas; i++)
            {
                pagos[i] = montoPagarPersona;
            }

            if (diferencia != 0)
            {
                pagos[0] = montoPagarPersona + (float)00.01;
            }

            return pagos;
        }

    }
}