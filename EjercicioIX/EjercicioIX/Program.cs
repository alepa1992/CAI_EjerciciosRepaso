using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EjercicioIX
{
    class Program
    {
        static void Main(string[] args)
        {

            string user;

            user = Validador.ValidarTexto("Bienvenido.\nPor favor ingrese el nombre de usuario para acceder al sistema.");

            if (user == "ALEJANDRO")
            {
                Console.WriteLine("¡Hola Alejandro!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No te conozco");
                Console.ReadKey();
            }

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
                    Console.WriteLine("Recuerde que solamente puede ingresar valores alfanumericos. No se permiten signos ni unicamente numeros");
                    res = Console.ReadLine().ToUpper();

                } while (String.IsNullOrWhiteSpace(res) || Regex.IsMatch(res, @"^[0-9]+$"));

                Console.Clear();

                return res;
            }
        }
    }
}
