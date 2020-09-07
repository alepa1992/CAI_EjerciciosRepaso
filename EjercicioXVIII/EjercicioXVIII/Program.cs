using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXVIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string bin, oct, hexa;

            do
            {
                Console.WriteLine("Por favor ingrese el numero en sistema decimal que desee convertir en binario, octal y hexadecimal");
                num = int.Parse(Console.ReadLine());

            } while (!int.TryParse(num.ToString(), out num));

            bin = Convert.ToString(num, 2);
            oct = Convert.ToString(num, 8);
            hexa = Convert.ToString(num, 16);

            Console.WriteLine("El numero ingresado en sistema decimal es: " + num);
            Console.WriteLine("El numero " + num + " en sistema binario es: " + bin);
            Console.WriteLine("El numero " + num + " en sistema octal es: " + oct);
            Console.WriteLine("El numero " + num + " en sistema hexadecimal es: " + hexa);
            Console.ReadKey();
        }
    }
}
