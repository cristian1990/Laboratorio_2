using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tareas Proc1 = new Tareas("Hilo 1", 5);
            Tareas Proc2 = new Tareas("Hilo 2", 10);

            //Llamamos a los 2 metodos que tenemos en la clase tarea.
            Thread hilo1 = new Thread(new ThreadStart(Proc1.tarea1));
            Thread hilo2 = new Thread(Proc2.tarea2);

            //Iniciamos los 2 procesos
            hilo1.Start();
            hilo2.Start();

            Console.ReadKey();
        }
    }
}
