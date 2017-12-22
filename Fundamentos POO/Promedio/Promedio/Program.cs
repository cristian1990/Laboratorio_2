using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el promedio de los examenes");

            int nota = 0;
            double sumador = 0;
            int cont = 0;
            char opcion = 's';

            do {
                Console.WriteLine("Introduzca nota");
                nota = Convert.ToInt32(Console.ReadLine());

                sumador += nota;
                cont++;
                Console.WriteLine("Desea seguir?");
            } while (opcion == 's');
            Console.ReadKey();
        }
    }
}
