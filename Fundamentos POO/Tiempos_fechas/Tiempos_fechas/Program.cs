using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos referencia

namespace Tiempos_fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esta clase "DateTime" Permite almacenar fechas y horas, y hacer operaciones entre ellas.

            //Inicializamos un objeto - inicilizamos la fecha
            //poner al estilo americano
            DateTime fecha = new DateTime(2017,09,10);
            //Agregamos otra fecha
            DateTime fechaDos = new DateTime(2017, 09, 05);

            //Agregamos 2 dias a la fecha
            fecha = fecha.Add(TimeSpan.FromDays(2));

            //Restamos fecha uno menos fecha dos
            TimeSpan diferencia = fecha - fechaDos;

            //Imprime el dia
            Console.WriteLine(fecha.Day);

            //imprime dia de la semana
            Console.WriteLine(fecha.DayOfWeek);

            //imprime dia del año
            Console.WriteLine(fecha.DayOfYear);

            //Imprimimos dia-mes-año
            Console.WriteLine(fecha.Day + "/" + fecha.Month + "/" + fecha.Year);

            //Imprimimos diferencia entre fechas
            Console.WriteLine(diferencia.Days);


            Console.ReadKey();
        }
    }
}
