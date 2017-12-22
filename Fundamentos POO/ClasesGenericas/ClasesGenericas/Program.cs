using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            MiColeccion<string, int> coleccion = new MiColeccion<string, int>();

            coleccion.Agregar("Juan",1);
            coleccion.Agregar("Pablo",5);
            coleccion.Agregar("Manuel",8);


            foreach (string item in coleccion.MiLista)
            {
                Console.WriteLine(item);
            }

            foreach (int item in coleccion.MiListaM)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
