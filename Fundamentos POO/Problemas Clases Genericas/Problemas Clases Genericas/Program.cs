using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas_Clases_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Probamos  con datos del tipo INT
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nProbamos  con datos del tipo INT\n");
            Operaciones<int> miOperacion = new Operaciones<int>();
            Console.WriteLine("\nLa suma es: {0}",miOperacion.Suma(5, 4));
            Console.WriteLine("\nLa resta es: {0}", miOperacion.Resta(8, 4));
            Console.WriteLine("\nLa multiplicacion es: {0}", miOperacion.Multiplicacion(4, 4));
            Console.WriteLine("\nLa division es: {0}", miOperacion.Division(100, 25));


            //Probamos con datos del tipo STRING
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nProbamos con datos del tipo STRING\n");
            Operaciones<string> otraOperacion = new Operaciones<string>();
            Console.WriteLine("La suma es: {0}", otraOperacion.Suma("Hola", " a todos"));

            //Da error porque la clase string no tiene una sobrecarga del operador de multiplicacion, si tiene de suma que es la concatenacion
            //Console.WriteLine("La multiplicacion es: {0}", otraOperacion.Multiplicacion("Hola", " a todos")); 

            Console.ReadKey();
        }
    }
}
