using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
	/// <summary>
	/// Ofrecemos al usuario elegir en que unidad desea hacer la conversion,
	/// si cualquier valor no es corecto el usuario debera poner una vez mas la 
	/// respuesta.
	/// Estas unidades son horas, minutos , segundos.
	/// En el caso de las horas, hara una coversion de horas a minutos utilizando
	/// el los metodos implementados en HadaP1.cs.
	/// En el caso de minutos, hara una conversion de minutos a segundos 
	/// y viseversa en el caso de los segundos.
	/// Despues se le dara la cantidad de la conversion 
	/// y se le preguntara si quieres hacer otra conversion
	/// </summary>
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
					Console.WriteLine("En que unidad desea hacer la conversion? (segundos , minutos , horas)");
					unidad = null;
					unidad = Console.ReadLine();
				} while (unidad !="segundos" && unidad !="minutos" && unidad != "horas");

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
				else if (unidad == "horas")
					Console.WriteLine("La cantidad de " + cantidad + " horas, nos un total de " + HadaP1.Horas2Minutes(cantidad) + " minutos");

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
