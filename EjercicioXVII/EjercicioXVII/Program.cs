using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EjercicioXVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sueldos = new int[5];
            string[] empleados = new string[5];

            for (int i = 0; i < 5; i++)
            {
                empleados[i] = Validador.ValidarTexto("Por favor ingrese el nombre del empleado numero " + (i + 1));
                sueldos[i] = Validador.ValidarInt("Por favor ingrese el sueldo del empleado numero " + (i + 1));
            }

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Empleado" + "\t | " + "Sueldo");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine(empleados[i] + "\t | " + sueldos[i]);
                }
                else
                {
                    Console.WriteLine(empleados[i] + "\t | " + sueldos[i]);
                }
            }

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
                Console.Clear();
                Console.WriteLine(msj);
                res = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(res) || Regex.IsMatch(res, @"^[0-9]+$"));

            return res;
        }

        public static int ValidarInt(string msj)
        {
            int res = 0;

            do
            {
                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine("Recuerde que solamente se permiten valores numericos.");
                res = int.Parse(Console.ReadLine());

            } while (!Regex.IsMatch(res.ToString(), @"^[0-9]+$"));

            return res;
        }


    }
}
