using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos los objetos de la clase tarea
            //Colocamos el nombre del proceso y el tiempo que durara cada proceso
            Tareas obj1 = new Tareas("Hilo1", 8);

            //Creamos los objetos de la clase tarea
            //Colocamos el nombre del proceso y el tiempo que durara cada proceso
            Tareas obj2 = new Tareas("Hilo2", 16);

            //Creamos los subprocesos
            Thread hilo1 = new Thread(obj1.Tarea1); //Llamamos a los metodos en la clase Tareas
            Thread hilo2 = new Thread(obj2.Tarea1); //Llamamos a los metodos en la clase Tareas

            //Inicializamos los subproceso
            hilo1.Start();
            hilo2.Start();

            Console.ReadKey();
        }
    }
}
