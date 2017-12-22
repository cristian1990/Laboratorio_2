using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_2
{
    public class Tareas
    {
        private string _nombre;
        private int _segundo;

        public Tareas(string nombre, int segundo)
        {
            this._nombre = nombre;
            this._segundo = segundo;
        }

        public void tarea1()
        {
            Console.WriteLine("{0} esta tares solo tendra {1}", _nombre, _segundo);
            Thread.Sleep(_segundo * 1000);
            Console.WriteLine("Tarea terminada: {0}", _nombre);
        }

        public void tarea2()
        {
            Console.WriteLine("{0} esta tares solo tendra {1}", _nombre, _segundo);
            Thread.Sleep(_segundo * 1000);
            Console.WriteLine("Tarea terminada: {0}", _nombre);
        }
    }

}
