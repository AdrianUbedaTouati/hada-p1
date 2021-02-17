using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
			bool continuar = true;
			string confirmacion;
			string unidad;
			double cantidad;

			
			

			do
			{
				
				
				do {
					Console.WriteLine("En que unidad desea hacer la conversion? (segundos o minutos)");
					unidad = null;
					unidad = Console.ReadLine();
				} while (unidad !="segundos" && unidad !="minutos");

				do
				{
					Console.WriteLine("Introduzca la cantidad de " + unidad + " que desea convertir (numero > 0)");
					cantidad = 0.0;
					cantidad =double.Parse(Console.ReadLine());
				} while (cantidad <= 0);

				if (unidad == "segundos")
					Console.WriteLine("La cantidad de "+ cantidad +" segundos, nos un total de " + HadaP1.Minutes2Seconds(cantidad) + " minutos");
				else if (unidad == "minutos")
					Console.WriteLine("La cantidad de " + cantidad + " minutos, nos un total de " + HadaP1.Seconds2Minutes(cantidad) + " segundos");

				do
				{
					Console.WriteLine("Quiere hacer otra conversion ? (si o no)");
					confirmacion = null;
					confirmacion = Console.ReadLine();
				} while (confirmacion != "si" && confirmacion != "no");

				if (confirmacion == "no")
					continuar = false;

			} while (continuar == true);
		}
    }
}
