using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(15, 3, Competencia.TipoCompetencia.F1);
            AutoF1 a1 = new AutoF1(1, "Mercedes", 5);
            AutoF1 a2 = new AutoF1(2, "Ferrari");
            AutoF1 a3 = new AutoF1(3, "RedBull");
            MotoCross m1 = new MotoCross(4, "Honda", 110);
            MotoCross m2 = new MotoCross(10, "Zanella", 150);

            if (competencia + m1)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }

            if (competencia + a1 )
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
