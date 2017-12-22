using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el refrigerador
            Refrigerador miRefri = new Refrigerador(70, -20);
            Random randon = new Random();

            //Adicionamos los handlers
            miRefri.AdicionaMetodoReservas(new Refrigerador.DReservasBajas(InformeKilos));
            miRefri.AdicionaMetodoDescongelado(new Refrigerador.DDescongelado(InformeGrados));

            //El refrigerador trabaja
            while(miRefri.Kilos > 0)
            {
                miRefri.Trabajar(randon.Next(1,5));
            }

            Console.ReadKey();
        }


        //Pongo los metodos aca porque gracias a los delegados tenemos comunicacion entre el objeto y cosas que se encuentran en program
        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }

        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--->Se descongela el refri, estoy a nivel de main");
            Console.WriteLine("--->Esta a {0} grados", pGrados);
        }
       
    }
}
