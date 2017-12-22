using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IEnumerable_e_IEnumerator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenedora datos = new Contenedora();

            //Loprimero que hace el foreach es arrancar por el reset()
            //Como el current regresa object nosotros en el foreach indicamos el tipo "int"
            foreach(int valor in datos)  //obtiene el IEnumerator de datos - invoca a GetEnumerator(), luevo invoca a MoveNext si tregresa "true"
            {                            
                Console.WriteLine(valor); //viene aca e implementa el foreach porque si hubo siguiente, si regresa "false" el foreach termina y pasa al siguiente codigo
            }

            Console.ReadKey();
        }
    }
}
