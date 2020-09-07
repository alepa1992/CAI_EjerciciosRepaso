using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace EjercicioIII
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string reordenada = "";
            int longitud;

            palabra = Validador.ValidarTexto("Por favor ingrese la palabra que desee saber si es palíndromo.");

            longitud = palabra.Length;

            for (int i = 1; i < longitud + 1; i++)
            {
                reordenada = String.Concat(reordenada, palabra.Substring(longitud - i, 1));
            }

            if (palabra == reordenada)
            {
                Console.WriteLine("La palabra " + palabra + " es palindromo.");
            }
            else
            {
                Console.WriteLine("La palabra " + palabra + " no es palindromo.");
            }

            Console.WriteLine(palabra);
            Console.WriteLine(reordenada);
            Console.ReadKey();
        }
        public class Validador
        {
            public static string ValidarTexto(string msj)
            {
                string res = "";

                do
                {
                    Console.Clear();
                    Console.WriteLine(msj);
                    Console.WriteLine("Recuerde que no se permiten valore nulos, espacios o numeros.");
                    res = Console.ReadLine().ToUpper();

                    Console.Clear();
                } while (string.IsNullOrWhiteSpace(res) || Regex.IsMatch(res, @"^[0-9]+$"));

                return res;
            }
        }

    }
}
