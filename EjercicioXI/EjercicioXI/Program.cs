using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EjercicioXI
{
    class Program
    {
        static void Main(string[] args)
        {

            //La logica acepta unicamente si se ingresa primero el nombre y luego el apellido sin importar las pocisiones con la edad
            string datosIngresados;
            string nombre = "", apellido = "";
            int edad = 0, n = 0, longitud;
            int edadCount, infoCount;

            string[] datos;

            Console.WriteLine("Bienvenido");

            do
            {
                edadCount = 0;
                infoCount = 0;

                Console.WriteLine("Por favor ingrese nombre, apellido y edad separados por un espacio por favor");
                datosIngresados = Console.ReadLine();

                datos = System.Text.RegularExpressions.Regex.Split(datosIngresados, " ");

                Console.Clear();

                longitud = datos.Length;

                for (int i = 0; i < longitud; i++)
                {
                    if (Regex.IsMatch(datos[i], "^[0-9]*$"))
                    {
                        edadCount = edadCount + 1;
                    }
                    else
                    {
                        infoCount = infoCount + 1;
                    }
                }
            } while (longitud != 3 || edadCount != 1 || infoCount != 2);




            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(datos[i], out n))
                {
                    edad = int.Parse(datos[i]);
                }
                else if (!int.TryParse(datos[i], out n) && String.IsNullOrEmpty(nombre))
                {
                    nombre = datos[i];
                }
                else if (!int.TryParse(datos[i], out n) && !String.IsNullOrEmpty(nombre))
                {
                    apellido = datos[i];
                }
            }

            Console.WriteLine("Nombre: " + nombre + ", Apellido: " + apellido + ", Edad: " + edad);
            Console.ReadKey();

        }
    }
}
