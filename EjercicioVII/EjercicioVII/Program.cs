using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EjercicioVII
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2, num3, num4, num5;

            int[] nums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                nums[i] = Validador.ValidarInt("Ingrese el valor numero " + (i + 1) + " de los 5 valores a ingresar.");

                Console.Clear();
            }

            Array.Sort(nums);

            Console.WriteLine("El menor valor de los 5 valores ingresados es: " + nums[0]);
            Console.WriteLine("El valor intermedio de los 5 valores ingresados es: " + nums[2]);
            Console.WriteLine("El mayor valor de los 5 valores ingresados es: " + nums[4]);

            Console.ReadKey();
        }

        public class Validador
        {
            public static int ValidarInt(string msj)
            {
                int res = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine(msj);
                    Console.WriteLine("Recuerde que solamente se pueden ingresar numeros.");
                    if (!int.TryParse(Console.ReadLine(), out res))
                    {
                        res = -1;

                        Console.Clear();
                    }
                } while (res < 0);

                return res;
            }
        }
    }
}
