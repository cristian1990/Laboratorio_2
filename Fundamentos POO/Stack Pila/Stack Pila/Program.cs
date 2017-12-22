using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio mi stack
            Stack miPila = new Stack();


            //Adicionamos Objetos con PUSH y mostramos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nAdicionamos Objetos con PUSH y Mostramos con Foreach\n");

            miPila.Push(5);
            miPila.Push(15);
            miPila.Push(23);
            miPila.Push(88);
            miPila.Push(92);
            miPila.Push(100);

            foreach (int numeros in miPila)
            {
                Console.WriteLine(numeros);
            }


            //Borramos el primero de la pila, el numero 100 con POP y mostramos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\n//Borramos el ultimo  de la pila, el numero 100 con POP y mostramos con Foreach\n");

            miPila.Pop();

            foreach(int numeros in miPila)
            {
                Console.WriteLine(numeros);
            }

            //Mostramos el primer numero de la pila despues de que se elimino el 100
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nBorramos Objetos con POP y mostramos con Foreach\n");
  
            Console.WriteLine(miPila.Peek());

            //Nos fijamos si existe un numero con CONTAINS
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nNos fijamos si existe un numero con CONTAINS\n");

            bool existe;

            existe = miPila.Contains(100);

            if(existe == false)
            {
                Console.WriteLine("El numero NO existe");
            }
            else
            {
                Console.WriteLine("El numero SI existe");
            }

            existe = miPila.Contains(92);

            if (existe == false)
            {
                Console.WriteLine("El numero NO existe");
            }
            else
            {
                Console.WriteLine("El numero SI existe");
            }

            Console.ReadKey();

        }
    }
}
