using System;
using System.Collections.Generic;

namespace Ejercicio_Modulo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            //Ejercicio 1
            /*int a = 5;
            int b = 10;
            int c = 15;
            int result = a + b + c;
            Console.WriteLine(result);
            dato = Console.ReadLine();*/

            //Ejercicio 2
            /*Console.WriteLine("Escriba un núnmero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro numero: ");
            int num2 = int.Parse( Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }else if (num1 > num2)
            {
                Console.WriteLine("El numero 1 es mayor que el otro");
            }
            else
            {
                Console.WriteLine("El numero 2 es mayor que el otro");
            }
            dato = Console.ReadLine();*/

            //Ejercicio 3
            /*Console.WriteLine("Ingrese el dia de hoy");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case "martes":
                    Console.WriteLine("Hoy es Martes");
                    break;
                case "miercoles":
                    Console.WriteLine("Hoy es Miercoles");
                    break;
                case "jueves":
                    Console.WriteLine("Hoy es Jueves");
                    break;
                case "viernes":
                    Console.WriteLine("Hoy es viernes");
                    break;
                case "sabado":
                    Console.WriteLine("Hoy es Sabado");
                    break;
                case "domingo":
                    Console.WriteLine("Hoy es domingo");
                    break;
                default:
                    Console.WriteLine("Ninguna opcion conincide.");
                    break;
            }
            dato = Console.ReadLine();*/

            //Ejercicio 4
            /*Console.WriteLine("Ingrese el precio del producto que pagará");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero segun su opción");
            Console.WriteLine("1. Efectivo \n" +
                              "2. Tarjeta");
            int opcion = int.Parse(Console.ReadLine());
            if(opcion == 2)
            {
                Console.WriteLine("Ingrese el numero de su tarjeta.");
                long noCuenta = long.Parse(Console.ReadLine());
            } else if (opcion == 1)
            {
                Console.WriteLine("Pago con efectivo, ingrse el dinero en caja");
            } else
            {
                Console.WriteLine("Ingrese una opción correcta.");
            }
            dato = Console.ReadLine();*/

            //Ejercicio 5
            /*int num = 1;
            for (int i = 0; num <= 100; i++)
            {
                Console.WriteLine(num);
                num++;
            }
            dato = Console.ReadLine();*/

            //Do While
            /*int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 100);
            dato = Console.ReadLine();*/


            //Ejercicio 6
            /*int num = 1;
            while(num <= 100)
            {
                Console.WriteLine(num);
                num++;
            }
            dato = Console.ReadLine();*/

            //Ejercicio 7
            /*int num = 0;
            while (num <= 100)
            {
                Console.WriteLine(num);
                num = num + 2;
            }
            dato = Console.ReadLine();*/

            //Ejercicio 8
            /*int num = 0;
            for (int i = 0; num <= 100; i++){
                Console.WriteLine(num);
                num = num + 3;
            }
            dato = Console.ReadLine();*/

            //Ejercicio 9
            /*int num = 0;
            List<int> numerosPares = new List<int> { };
            for (int i = 0; num <= 100; i++)
            {
                numerosPares.Add(num);
                num++;
            }

            foreach (int datos in numerosPares)
            {
                Console.WriteLine(datos);
            }
            dato = Console.ReadLine();*/

            //Ejercicio 10
            /*List<int> listaNumeros = new List<int> { };
            int opcion = 1;
            int num;
            int pares = 0;
            int impares = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                listaNumeros.Add(num);
                opcion++;
            } while (opcion <=10);

            foreach(int datos in listaNumeros)
            {
                int resultado = datos % 2;
                if(resultado == 0)
                {
                    pares += datos;
                }
                else
                {
                    impares += datos;
                }
            }
            int total = pares - impares;
            Console.WriteLine("El resultado de sumar los pares y restarles los pares es: " + total);
            dato = Console.ReadLine();*/

            //Ejercicio 11
            /*Console.WriteLine("Escribe un numero del 1 al 7");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case 2:
                    Console.WriteLine("Hoy es Martes");
                    break;
                case 3:
                    Console.WriteLine("Hoy es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Hoy es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Hoy es Viernes");
                    break;
                case 6:
                    Console.WriteLine("Hoy es Sabado");
                    break;
                case 7:
                    Console.WriteLine("Hoy es Domingo");
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
            dato = Console.ReadLine();*/

            //Ejercicio 12
            /*Console.WriteLine("Ingrese un numero del 1 al 1000");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 1000) {
                int contador = 0;
                int suma = 0;
                Console.WriteLine("Numero valido");
                while(contador <= num)
                {
                    suma += contador;
                    contador++;
                }
                Console.WriteLine("La suma de los numeros del 1 al ingresado es: " + suma);
            }
            else
            {
                Console.WriteLine("Rango invalido!! ingrese un numero entre 1 y 1000");
            }
            dato = Console.ReadLine();*/

            //Ejercicio 13
            /*Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            bool esPrimo = true;

            if (numero < 2)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }
            if (esPrimo)
            {
                Console.WriteLine(numero + " es un número primo.");
            }
            else
            {
                Console.WriteLine(numero + " no es un número primo.");
            }
            dato = Console.ReadLine();*/

            //Ejercicio 14
            Console.Write("Ingresa un número: ");
            int num = int.Parse(Console.ReadLine());

            if(num <= 0)
            {
                Console.WriteLine("Ingrese un numero positivo o mayor a 0");
            }else
            {
                int contador = 0;

                while(num > 0)
                {
                    num = num / 10;
                    contador++;
                }
                Console.WriteLine("El número tiene " + contador + " cifras.");
            }
            dato = Console.ReadLine();
        }
    }
}
