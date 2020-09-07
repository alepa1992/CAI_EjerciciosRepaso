using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI
{
    class Program
    {
        static void Main(string[] args)
        {

            //Numero de registro: 890297
            for (int i = 1; i < 298; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }

                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i + "- Foo");
                }

                if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + "- Bar");
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + "- FooBar");
                }
            }

            Console.ReadKey();

        }
    }
}
