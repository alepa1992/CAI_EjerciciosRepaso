using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVIII
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha2, hoy;
            string fecha;
            int cantDias = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Por favor ingrese la fecha con la que vamos a trabajar. Debe respetar el formato YYYY/MM/DD.");
                fecha = Console.ReadLine();
            } while (ValidarFecha(fecha) == false);

            Console.Clear();

            hoy = DateTime.Now;

            fecha2 = DateTime.Parse(fecha);

            if (fecha2 > hoy)
            {
                cantDias = (fecha2.Date - hoy.Date).Days;
            }
            else
            {
                cantDias = (hoy.Date - fecha2.Date).Days;
            }

            Console.WriteLine("La diferencia de fechas es de " + cantDias + " dias.");
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
    }
}
