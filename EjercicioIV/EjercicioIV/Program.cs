using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjercicioIV
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1, palabra2;

            Console.WriteLine("Bienvenido al convalidador de anagramas. Presione cualquier tecla para continuar.");
            Console.ReadKey();

            palabra1 = Validador.ValidarTexto("Por favor igrese la primera palabra.");

            palabra2 = Validador.ValidarTexto("Por favor ingrese la segunda palabra.");

            Console.WriteLine("La primera palabra es: " + palabra1);
            Console.WriteLine("La segunda palabra es: " + palabra2);

            palabra1 = String.Concat(palabra1.OrderBy(c => c));
            palabra2 = String.Concat(palabra2.OrderBy(c => c));

            if (palabra1 == palabra2)
            {
                Console.WriteLine("Las palabras ingresadas son un anagrama");
            }
            else
            {
                Console.WriteLine("Las palabras ingresadas no son un anagrama");
            }

            Console.ReadKey();

        }
        public class Validador
        {
            public static string ValidarTexto(string msj)
            {
                string res;

                do
                {
                    Console.Clear();
                    Console.WriteLine(msj);
                    Console.WriteLine("Recuerde que no se aceptan valores nulos, espacios o numeros.");
                    res = Console.ReadLine().ToUpper();

                    Console.Clear();
                } while (string.IsNullOrWhiteSpace(res) || Regex.IsMatch(res, @"^[0-9]+$"));

                return res;
            }
        }
    }
}
