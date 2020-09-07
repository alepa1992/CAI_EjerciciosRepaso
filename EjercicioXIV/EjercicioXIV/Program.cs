using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EjercicioXIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, multiplicador = 0, res = 0;
            string numero;

            do
            {
                Console.WriteLine("Por favor ingrese el numero de la tabla de multiplicar que desea ver");
                numero = Console.ReadLine();

            } while (!Regex.IsMatch(numero, @"^[0-9]+$"));

            num = int.Parse(numero);


            int[,] tabla = new int[num + 1, 2];

            for (int i = 0; i < num + 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == 0)
                    {
                        tabla[i, j] = 0;
                    }
                    else if (i != 0)
                    {
                        if (j == 0)
                        {
                            tabla[i, j] = i;
                        }
                        else if (j == 1)
                        {
                            tabla[i, j] = i * num;
                        }
                    }
                }
            }

            for (int i = 0; i < num + 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        multiplicador = tabla[i, j];
                    }
                    else if (j == 1)
                    {
                        res = tabla[i, j];
                    }
                }

                Console.WriteLine(multiplicador + "\t | " + res);
            }

            Console.ReadKey();
        }
    }
}
