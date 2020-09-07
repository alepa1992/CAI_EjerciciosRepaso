using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioII
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;

            //Numero de registro 890297
            for (int i = 1; i < 298; i++)
            {
                sum = 1;

                if (i == 1 || i == 2)
                {
                    Console.WriteLine(i + " - Es primo");
                }
                else if (i == 3)
                {
                    Console.WriteLine(i + " - Es primo y es divisible por 3");
                }
                else
                {
                    for (int j = 2; j < 298; j++)
                    {
                        if (i % j == 0)
                        {
                            sum = sum + j;
                        }
                    }

                    if (sum == (i + 1))
                    {
                        Console.WriteLine(i + " - Es primo");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine(i + " - Es divisible por 3");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

            }

            Console.ReadKey();

        }
    }
}
