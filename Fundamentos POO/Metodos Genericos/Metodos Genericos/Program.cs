using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos los valores para la asignacion de las variables de tipo INT
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nCreamos los valores para la asignacion de las variables de tipo INT\n");

            int x = 5;
            int y = 3;

            Console.WriteLine("x={0}, y={1}", x, y);
            Intercambio<int>(ref x, ref y); // Aqui las "T" se convierten en INT
            Console.WriteLine("x={0}, y={1}", x, y);



            //Creamos los valores para la asignacion de las variables de tipo DOUBLE
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nCreamos los valores para la asignacion de las variables de tipo DOUBLE\n");

            double n = 55.12;
            double m = 32.45;

            Console.WriteLine("x={0}, y={1}", n, m);
            Intercambio<double>(ref n, ref m); // Aqui las "T" se convierten en DOUBLE
            Console.WriteLine("x={0}, y={1}", n, m);



            //Creamos los valores para la asignacion de las variables de tipo STRING
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nCreamos los valores para la asignacion de las variables de tipo STRING\n");

            string e = "Hola";
            string f = "Chau";

            Console.WriteLine("x={0}, y={1}", e, f);
            Intercambio<string>(ref e, ref f); // Aqui las "T" se convierten en STRING
            Console.WriteLine("x={0}, y={1}", e, f);



            Console.ReadKey();
        }


        //la "T" simboliza a un tipo generico(int, bool, una clase, etc)
        static void Intercambio<T>(ref T a, ref T b) //Parametro (a y b) de tipo generico y de referencia. No siempre tienen que ser REF
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }

    }
}
