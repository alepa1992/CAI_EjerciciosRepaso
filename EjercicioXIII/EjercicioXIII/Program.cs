using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace EjercicioXIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, res = 1;
            string numero;
            do
            {
                Console.WriteLine("Por favor ingrese el numero del que desea sacar el factorial");
                numero = Console.ReadLine();
            } while (!Regex.IsMatch(numero, @"^[0-9]+$"));

            num = int.Parse(numero);


            for (int i = 0; i < num; i++)
            {
                if (i != 0)
                {
                    res = res * (i + 1);
                }
            }

            Console.WriteLine("El factorial de " + num + " es " + res);
            Console.ReadKey();
        }
    }
}
