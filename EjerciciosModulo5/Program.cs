using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosModulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            /*float cantidad;
            float conversion;
            Console.WriteLine("Ingrese la opcion que desea: \n" +
                               "1. Dolar a euro \n" +
                               "2. Euro a dolar");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tipo de cambio del dia de hoy");
            float cambioHoy = float.Parse(Console.ReadLine());
            switch (opcion) {
                case 1:
                    Console.WriteLine("Ingrese la cantidad a cambiar.");
                    cantidad = float.Parse(Console.ReadLine());
                    conversion = Convertir(cantidad, cambioHoy);
                    Console.WriteLine(cantidad + " => " + conversion + " euros ");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad a cambiar.");
                    cantidad = float.Parse(Console.ReadLine());
                    conversion = Convertir(cantidad, cambioHoy);
                    Console.WriteLine(cantidad + " => " + conversion + " dolares ");
                    break;
                default:
                    Console.WriteLine("Ingrese un opcion valida.");
                    break;
            }
            float Convertir(float cantidadConvertir, float cambio)
            {
                return cantidadConvertir * cambio;
            }*/

            //Ejercicio 2
            /*int num1;
            int num2;
            int resultado;
            Console.WriteLine("Ingrese la opcion a realizar: \n" +
                              "1. Suma \n" +
                              "2. Resta \n" +
                              "3. Multiplicación \n" +
                              "4. División");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion) {
                case 1:
                    Console.WriteLine("Ingrese el primer numero");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = Sumar(num1, num2);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el primer numero");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = Restar(num1, num2);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el primer numero");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    resultado = Multiplicar(num1, num2);
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 4:
                    Console.WriteLine("Ingrese el primer numero");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    num2 = int.Parse(Console.ReadLine());
                    Division(num1, num2);
                    break;
                default:
                    break;
            }
            int Sumar(int numero1, int numero2)
            {
                return numero1 + numero2;
            }
            int Restar(int numero1, int numero2)
            {
                return numero1 - numero2;
            }
            int Multiplicar(int numero1, int numero2)
            {
                return numero1 * numero2;
            }
            void Division(int numero1, int numero2)
            {
                if (numero2 == 0) {
                    Console.WriteLine("No se puede dividir entre 0");
                }
                else
                {
                    int total = numero1 / numero2;
                    Console.WriteLine("El resultado es: " + total);
                }
            }
            Console.ReadLine();*/

            //Ejercicio 3
            /*double [] valor = { 200, 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };

            string[] billetes = {"Billete de 200", "Billete de 100", "Billete de 50", "Billete de 20",
                                  "Billete de 10", "Billete de 5", "Billete de 1", "50 centavos",
                                  "25 centavos", "10 centavos", "5 centavos", "1 centavo"};

            Console.WriteLine("Ingrese el valor a desglosar");
            double desglosar = double.Parse(Console.ReadLine());
            RealizarDesglose(desglosar);

            void RealizarDesglose(double importe)
            {
                for (int i = 0; i < valor.Length; i++)
                {
                    int cantidad = (int)(importe / valor[i]);
                    if (cantidad > 0)
                    {
                        Console.WriteLine($"{cantidad} {billetes[i]}");
                        importe -= cantidad * valor[i];
                    }
                }
            }
            Console.ReadLine();*/

            //Ejercicio 4
            /*Console.WriteLine("Ingrese una letra");
            char letra = Char.Parse(Console.ReadLine());

            if (EsVocal(letra))
            {
                Console.WriteLine("La letra es una vocal");
            }
            else if (EsNumero(letra))
            {
                Console.WriteLine("La letra es un dígito");
            }
            else if (EsConsonante(letra))
            {
                Console.WriteLine("La letra es una consonante");
            }
            else
            {
                Console.WriteLine("No es una letra válida");
            }

            bool EsVocal(char c)
            {
                c = Char.ToLower(c);
                return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            }

            bool EsNumero(char c)
            {
                return Char.IsDigit(c);
            }

            bool EsConsonante(char c)
            {
                c = Char.ToLower(c);
                return !EsVocal(c) && !EsNumero(c) && char.IsLetter(c);
            }
            Console.ReadLine();*/

            //Ejercicio 5
            /*Console.WriteLine("Ingrese el numero de la tabla de multiplicar a generar");
            int numero = int.Parse(Console.ReadLine());
            Tabla(numero);

            void Tabla (int num)
            {
                
                for(int i = 0; i <= 10; i++)
                {
                    int resultado = i * num;
                    Console.WriteLine(num + " X " + i + " = " + resultado);
                }
            }
            Console.ReadLine();*/

            //Ejercicio 6
            List<int> numeros = new List<int>();
            int constante = 0;

            while (true)
            {
                Console.WriteLine("Ingrese un numero");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }

                numeros.Add(numero);
            }

            MostraInformacion(numeros);

            void MostraInformacion(List<int> num)
            {
                int numAlto = num.Max();
                int numBajo = num.Min();
                int diferencia = numAlto - numBajo;
                int cantidad = num.Count();

                Console.WriteLine("El numero mas alto es: " + numAlto);
                Console.WriteLine("El numero mas bajo es: " + numBajo);
                Console.WriteLine("La diferencia del numero mas alto y el bajo es: " + diferencia);
                Console.WriteLine("La cantidad de numero ingresados es: " + cantidad);
            }
            Console.ReadLine();
        }
    }
}
