using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EjercicioX
{
    class Program
    {
        static void Main(string[] args)
        {
            string caracter;
            string keep = "";
            int n;

            do
            {
                Console.WriteLine("Por favor ingrese el valor que desea evaluar");
                caracter = Console.ReadLine().ToUpper();

                while (caracter.Length > 1 || !Regex.IsMatch(caracter, "^[a-zA-Z0-9]*$"))
                {
                    Console.Clear();
                    Console.WriteLine("Recuerde que el valor que puede ingresar es unicamente de una posicion y no puede contener simbolos");
                    caracter = Console.ReadLine().ToUpper();
                }

                if (caracter == "A" || caracter == "E" || caracter == "I" || caracter == "O" || caracter == "U")
                {
                    Console.WriteLine("El caracter ingresado por el usuario es una vocal.");

                    do
                    {
                        Console.WriteLine("Desea probar ingresando otro caracter? [Y/N]");
                        keep = Console.ReadLine().ToUpper();
                    } while (keep != "Y" && keep != "N");

                }
                else if (int.TryParse(caracter, out n))
                {
                    Console.WriteLine("El caracter ingresado por el usuario es un numero.");

                    do
                    {
                        Console.WriteLine("Desea probar ingresando otro caracter? [Y/N]");
                        keep = Console.ReadLine().ToUpper();
                    } while (keep != "Y" && keep != "N");

                }
                else
                {
                    Console.WriteLine("El caracter ingresado por el usuario es una consonante.");

                    do
                    {
                        Console.WriteLine("Desea probar ingresando otro caracter? [Y/N]");
                        keep = Console.ReadLine().ToUpper();
                    } while (keep != "Y" && keep != "N");
                }

                Console.Clear();
            } while (keep == "Y");

        }
    }
}
