using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXII
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada1, entrada2;
            int years, months, days;

            do
            {
                Console.Clear();
                Console.WriteLine("Por favor ingrese la primera fecha con la que vamos a trabajar. Debe respetar el formato YYYY/MM/DD.");
                entrada1 = Console.ReadLine();
            } while (ValidarFecha(entrada1) == false);

            DateTime fecha1 = new DateTime(Substr(entrada1, 0, 4), Substr(entrada1, 5, 2), Substr(entrada1, 8, 2));


            do
            {
                Console.Clear();
                Console.WriteLine("Por favor ingrese la segunda fecha con la que vamos a trabajar. Debe respetar el formato YYYY/MM/DD.");
                entrada2 = Console.ReadLine();
            } while (ValidarFecha(entrada2) == false);

            DateTime fecha2 = new DateTime(Substr(entrada2, 0, 4), Substr(entrada2, 5, 2), Substr(entrada2, 8, 2));


            DateTime zeroTime = new DateTime(1, 1, 1);

            fecha1 = DateTime.Parse(entrada1);
            fecha2 = DateTime.Parse(entrada2);


            if (fecha2 > fecha1)
            {
                TimeSpan span = fecha2 - fecha1;
                years = (zeroTime + span).Year - 1;
                months = (zeroTime + span).Month - 1;
                days = (zeroTime + span).Day - 1;
            }
            else
            {
                TimeSpan span = fecha1 - fecha2;
                years = (zeroTime + span).Year - 1;
                months = (zeroTime + span).Month - 1;
                days = (zeroTime + span).Day - 1;
            }


            Console.WriteLine("La diferencia entre ambas fechas es de " + years + " anos, " + months + " meses y " + days + " dias.");
            Console.ReadKey();

        }

        public static bool ValidarFecha(string fecha)
        {
            DateTime fromDateValue;
            var formats = new[] { "yyyy/MM/dd" };
            if (DateTime.TryParseExact(fecha, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Substr(string str, int index, int len)
        {
            int res;

            res = int.Parse(str.Substring(index, len));

            return res;
        }
    }
}
