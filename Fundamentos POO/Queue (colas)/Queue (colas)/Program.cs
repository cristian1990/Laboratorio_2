using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue__colas_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio Queue
            Queue miCola = new Queue();


            //Adicionamos Objetos con ENQUEUE y Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nAdicionamos Objetos con ENQUEUE y Mostramos con Foreach\n");
            miCola.Enqueue("Televisor");
            miCola.Enqueue("Monitor");
            miCola.Enqueue("Heladera");
            miCola.Enqueue("Lavarropas");
            miCola.Enqueue("Tablet");

            foreach (string Electro in miCola)
            {
                Console.WriteLine(" {0} ",Electro);      
            }


            //Eliminamos el primer elemento de la cola con DEQUEUE y mostramos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nEliminamos el primer elemento de la cola con DEQUEUE y mostramos con Foreach\n");
            miCola.Dequeue();
            miCola.Dequeue();

            foreach (string Electro in miCola)
            {
                Console.WriteLine(" {0}", Electro);
            }


            //Eliminamos el primer elemento de la cola con DEQUEUE y mostramos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nvolvemos a cargar Objetos con ENQUEUE y Mostramos con Foreach\n");
            miCola.Enqueue("Celular");
            miCola.Enqueue("Parlante");

            foreach (string Electro in miCola)
            {
                Console.WriteLine(" {0} ", Electro);
            }


            //Observamos el primer elemento de la cola con PEEK
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nObservamos el primer elemento de la cola con PEEK\n");

            Console.WriteLine(miCola.Peek());


            //Observamos la cantidad de elementos con COUNT
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nObservamos la cantidad de elementos con COUNT\n");

            Console.WriteLine(miCola.Count);


            //Verificamos si existe un elemento con CONTAINS
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nVerificamos si existe un elemento con CONTAINS\n");

            bool existe;

            existe = miCola.Contains("Heladera");

            if (existe == false)
                Console.WriteLine("El elemento No existe");

            if (existe == true)
                Console.WriteLine("El elemento existe");

            existe = miCola.Contains("Placard");

            if (existe == false)
                Console.WriteLine("El elemento No existe");

            if (existe == true)
                Console.WriteLine("El elemento existe");

            Console.ReadKey();
        }
    }
}
