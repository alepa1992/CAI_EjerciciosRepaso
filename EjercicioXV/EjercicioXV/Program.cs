using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;

namespace EjercicioXV
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string user, pass;

            Console.WriteLine("Bienvenido");
            user = Validador.ValidarTexto("Por favor ingrese el usuario");

            do
            {
                Console.Clear();

                pass = Validador.ValidarTexto("Por favor ingrese la contraseña");

                if (pass != user)
                {
                    count = count + 1;
                    Console.WriteLine("Acceso denegado. La constraseña no es correcta.");
                }

            } while (count < 3 && pass != user);

            if (count == 3)
            {
                Console.WriteLine("Clave bloqueada.");
                Console.ReadKey();
            }
            else if (pass == user)
            {
                Console.WriteLine("Bienvenido, " + user);
                Console.ReadKey();
            }

        }

        public class Validador
        {
            public static string ValidarTexto(string msj)
            {
                string res = "";

                do
                {
                    Console.WriteLine();
                    Console.WriteLine(msj);
                    res = Console.ReadLine().ToUpper();

                    Console.Clear();
                } while (string.IsNullOrWhiteSpace(res) || Regex.IsMatch(res, @"^[0-9]+$"));

                return res;

            }
        }
    }
}
