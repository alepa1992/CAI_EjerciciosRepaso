using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EjericioVI
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.WriteLine("Bienvenido.");

            num1 = Validador.ValidarInt(0, 999999, "Por favor ingrese el valor del primer numero que quiera que forme parte de la ecuacion.");

            Console.Clear();

            num2 = Validador.ValidarInt(0, 999999, "Por favor ingrese el valor del segundo numero que quiera que forme parte de la ecuacion.");

            Console.Clear();

            resultado = Aritmetica.Producto(Aritmetica.Suma(num1, num2), Aritmetica.Resta(num1, num2));

            Console.WriteLine("El resultado de la ecuacion en base a los valores ingresados es de: " + resultado);
            Console.ReadKey();
        }

        public class Validador
        {
            public static int ValidarInt(int min, int max, string msj)
            {
                int res;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine(msj);
                    Console.WriteLine("La aplicacion permite unicamente valores numerico entre " + min + " y " + max);
                    if (!int.TryParse(Console.ReadLine(), out res))
                    {
                        Console.WriteLine("Por favor ingrese un numero");
                        res = -1;

                        Console.Clear();
                    }
                } while (res < min || res > max);

                return res;
            }
        }

        public class Aritmetica
        {
            public static int Suma(int num1, int num2)
            {
                int res;

                res = num1 + num2;

                return res;
            }

            public static int Resta(int num1, int num2)
            {
                int res;

                res = num1 - num2;

                return res;
            }

            public static int Producto(int num1, int num2)
            {
                int res;

                res = num1 * num2;

                return res;
            }
        }
    }
}
