using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_3
{
    public class Tareas
    {
        private string _nombre;
        private int _segundos;

        public Tareas(string nombre, int segundo)
        {
            this._nombre = nombre;
            this._segundos = segundo;
        }

        public Tareas()
        {
        }

        //Metodo de tarea Uno
        public void Tarea1()
        {
            Console.WriteLine(_nombre + " Esta tarea solo tendra " + _segundos + " segundos.");

            //le damos 1 segundo de tiempo de ejecucion de este proceso
            Thread.Sleep(_segundos * 1000);

            //Cuando termine su segundo nos da este mensaje
            Console.WriteLine("Tarea terminada: " + _nombre);
        }

    }
}
