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
            List <string> tarea = new List<string>();
            tarea.Add("Hilo1");
            tarea.Add("Hilo2");
            tarea.Add("Hilo3");

            List<int> segundos = new List<int>();
            segundos.Add(2);
            segundos.Add(8);
            segundos.Add(10);

   

            Tareas obj1 = new Tareas();

            foreach (string auxTarea in tarea)
            {
                string tareas = auxTarea;

                foreach (int auxSegundo in segundos)
                {
                    int segund = auxSegundo;
                    obj1 = new Tareas(tareas, segund);
                }
            }

            Thread hilo1 = new Thread(obj1.Tarea1); //Llamamos a los metodos en la clase Tareas
            hilo1.Start();

            Console.ReadKey();
        }
    }
}
