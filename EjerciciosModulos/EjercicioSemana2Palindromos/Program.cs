using System;
using System.Text;

namespace EjercicioSemana2Palindromos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra o frase");
            string frase = Console.ReadLine().Trim();
            bool esPalindromo = EsPalindromo(frase);
            if (esPalindromo == true)
            {
                Console.WriteLine("La palabra o frase es PALÍNDROMO.");
            }
            else
            {
                Console.WriteLine("La palabra o frase no es PALÍNDROMO.");
            }
            Console.ReadKey();
        }

        static bool EsPalindromo(string frase)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in frase)
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToLower(c));
                }
            }

            string cadenaLimpia = sb.ToString();
            char[] arrayFrase = cadenaLimpia.ToCharArray();

            Array.Reverse(arrayFrase);
            string fraseReversa = new string(arrayFrase);

            return cadenaLimpia.Equals(fraseReversa);
        }
    }
}