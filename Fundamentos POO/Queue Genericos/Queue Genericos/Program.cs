using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adicionamos instancias con ENQUEUE y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nAdicionamos instancias con ENQUEUE y Mostramos con Foreach\n");

            Queue<CPunto> puntos = new Queue<CPunto>();

            puntos.Enqueue(new CPunto(1, 10));
            puntos.Enqueue(new CPunto(2, 20));
            puntos.Enqueue(new CPunto(3, 30));
            puntos.Enqueue(new CPunto(4, 40));

            foreach(CPunto pun in puntos)
            {
                Console.WriteLine(pun);
            }


            //Mostramos el primer elemento de la cola o Queue con PEEK 
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nMostramos el primer elemento de la cola o Queue con PEEK \n");

            Console.WriteLine(puntos.Peek());


            //Elliminamos el primer elemento de la cola con DEQUEUE y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nElliminamos el primer elemento de la cola con DEQUEUE y recorremos con Foreach\n");

            puntos.Dequeue();

            foreach (CPunto pun in puntos)
            {
                Console.WriteLine(pun);
            }


            Console.ReadKey();
        }
    }
}
