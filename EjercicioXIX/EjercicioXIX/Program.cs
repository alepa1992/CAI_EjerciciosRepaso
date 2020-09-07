using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjercicioXIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;

            cant = Validador.ValidarInt("Por favor ingrese la cantidad de palabras que desea ingresar y saber la longitud.");

            string[] palabra = new string[cant];
            string[] longitud = new string[cant];

            for (int i = 0; i < cant; i++)
            {
                palabra[i] = Validador.ValidarTexto("Por favor ingrese la palabra que desea conocer la longitud.");
                longitud[i] = palabra[i].Length.ToString();
            }

            for (int i = -1; i < cant; i++)
            {
                if (i == -1)
                {
                    Console.WriteLine("Palabra \t | Longitud");
                    Console.WriteLine("---------------------");
                }
                else
                {
                    Console.WriteLine(palabra[i] + " \t | " + longitud[i]);
                }
            }

            Console.ReadKey();
        }
    }

    public class Validador
    {
        public static int ValidarInt(string msj)
        {
            int res;
            string cant;

            do
            {
                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine("Recuerde que solamente puede ingresar valores numericos");
                cant = Console.ReadLine();

            } while (!int.TryParse(cant.ToString(), out res));

            return res;
        }

        public static string ValidarTexto(string msj)
        {
            string res = "";

            do
            {
                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine("Recuerde que no se pueden ingresar valores nulos o simbolos.");
                res = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(res) || Regex.IsMatch(res, @"[a-zA-z]^$"));

            return res;

        }
    }
}
