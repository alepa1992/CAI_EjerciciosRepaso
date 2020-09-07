using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XVI
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 0, longitud = 0;
            bool check;

            do
            {
                Console.WriteLine("Por favor ingrese el numero que desee saber cuantos digitos tiene.");
                if (!long.TryParse(Console.ReadLine(), out num))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            } while (check != true);

            longitud = num.ToString().Length;

            Console.WriteLine("Numero insdgresado: " + num + " - Tiene " + longitud + " digitos.");
            Console.ReadKey();
        }
    }
}
