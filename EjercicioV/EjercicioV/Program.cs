using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EjercicioV
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int pepe = 0;
            string invertido = "";

            numero = Validador.ValidarInt(10000, 99999, "Por favor ingrese el numero que desee ver invertido");
            //Console.WriteLine("Ingrese numero");
            //numero = int.Parse(Console.ReadLine(),);

            for (int i = 1; i < 5 + 1; i++)
            {
                invertido = String.Concat(invertido, (numero.ToString()).Substring(5 - i, 1));
            }

            Console.WriteLine(invertido);

            Console.ReadKey();

        }

        public class Validador
        {
            public static int ValidarInt(int min, int max, string msj)
            {
                int res;

                do
                {
                    Console.Clear();
                    Console.WriteLine(msj);
                    Console.WriteLine("Recuerde que el numero a ingresar debe encontrarse entre " + min + " y " + max);
                    if (!int.TryParse(Console.ReadLine(), out res))
                    {
                        Console.WriteLine("Ingrese un numero por favor");
                        res = -1;

                        Console.Clear();
                    }
                } while (res < min || res > max);

                return res;
            }
        }
    }
}
