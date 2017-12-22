using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adicionamos nuevas instancias con PUSH
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nAdicionamos nuevas instancias con PUSH\n");

            Stack<CPunto> puntos = new Stack<CPunto>();
            puntos.Push(new CPunto(1, 10));
            puntos.Push(new CPunto(2, 20));
            puntos.Push(new CPunto(3, 30));
            puntos.Push(new CPunto(4, 40));

            foreach(CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            //Obtenemos el primer elemento de la pila o stack con PEEK
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nObtenemos el primer elemento de la pila o stack con PEEK\n");

            Console.WriteLine(puntos.Peek());

            //Eliminamos el primer elemento de la pila o stack con POP
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nEliminamos el primer elemento de la pila o stack con POP\n");

            puntos.Pop();

            foreach (CPunto pun in puntos)
            {
                Console.WriteLine(pun);
            }         

            Console.ReadKey();
        }
    }
}
