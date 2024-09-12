using System;

namespace CuentaConPropina
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            DateTime fechaHoraActual = DateTime.Now;
            string fechaFormateada = fechaHoraActual.ToString("dd/MM/yyyy");
            string horaFormateada = fechaHoraActual.ToString("hh:mm tt");

            Console.WriteLine("Ingrese el total a pagar de su cuenta.");
            float totalCuenta = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el % de propina que desea agregar a la cuenta.");
            float porcentaje = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de personas que participaran en el pago.");
            int numPersonas = int.Parse(Console.ReadLine());

            float totalPagar = TotalPagar(totalCuenta, porcentaje);
            float[] pagoXPersona = PagoXPersona(totalPagar, numPersonas);

            String mensaje = ConvertirNumeroLetras(totalPagar);

            Console.WriteLine($"El total a pagar contando propina es de: Q{totalPagar}\n" +
                              $"{mensaje}");

            for (int i = 0; i < pagoXPersona.Length; i++)
            {
                Console.WriteLine($"La persona no.{contador} Paga: Q{pagoXPersona[i]}");
                contador++;
            }

            Console.WriteLine($"{fechaFormateada} {horaFormateada}");

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

        static String ConvertirNumeroLetras(float numero)
        {

            String[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            String[] decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", 
                                 "ochenta", "noventa" };
            String[] centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", 
                                  "seiscientos", "setecientos", "ochocientos", "novecientos" };
            String[] millares = { "", "mil", "dos mil"};
            String mensaje = "";

            int millar = (int)numero/1000;
            int centena = (int)(numero % 1000) / 100;
            int decena = (int)(numero % 100) / 10;
            int unidad = (int)numero % 10;

            int entero = (int)Math.Floor(numero);
            int centavos = (int)Math.Round((numero - entero) * 100);
            int decima = (int)centavos / 10;
            int centecima = (int)centavos % 10;

            if(centavos > 0 )
            {
                mensaje = $"{millares[millar]} {centenas[centena]} {decenas[decena]} y {unidades[unidad]} con " +
                          $"{decenas[decima]} y {unidades[centecima]} centavos.".Trim();
            }else
            {
                mensaje = $"{millares[millar]} {centenas[centena]} {decenas[decena]} y {unidades[unidad]} con cero centavos.".Trim();
            }

            return mensaje;
        }
    }
}