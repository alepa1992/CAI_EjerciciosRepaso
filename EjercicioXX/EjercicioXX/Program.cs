using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXX
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0, cantPrimos = 0;
            long factorial = 1;

            num = Validador.ValidarInt("Por favor ingrese un numero");

            for (int i = 0; i < num; i++)
            {
                if (i != 0)
                {
                    factorial = factorial * (i + 1);
                }
            }

            for (int i = 1; i < num + 1; i++)
            {
                for (int j = 1; j < num + 1; j++)
                {
                    if (i % j == 0)
                    {
                        count = count + 1;
                    }
                }

                if (count == 2 || i == 1)
                {
                    cantPrimos = cantPrimos + 1;
                }

                count = 0;
            }

            Console.WriteLine("Hasta el " + num + " hay " + cantPrimos + " numeros primos y su factorial de " + num + " es " + factorial);
            Console.ReadKey();
        }
    }

    public class Validador
    {
        public static int ValidarInt(string msj)
        {
            int res;
            string num;

            do
            {
                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine("Recuerde que solo se permiten valores numericos.");
                num = Console.ReadLine();
            } while (!int.TryParse(num.ToString(), out res));

            return res;
        }
    }
}
