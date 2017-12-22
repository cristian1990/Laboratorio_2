using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Clases_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------------------------------------

            //Listas - creamos una lista
            //miLista es un objeto del tipo lista
            List<int> miLista = new List<int>();
            miLista.Add(4);
            miLista.Add(8);
            miLista.Add(10);
            miLista.Add(8);

            //contains indica si contiene el elemento que le pasamos como parametro.
            // miLista.Contains(8);
            Console.WriteLine(miLista.Contains(8)); //Devuelve true porque efectivamente contiene ese numero. 

            //insert - para insertar un elemento en la lista
            //insertamos un elemento en la posicion 3 el numero 9 agrandamos la lista.
            miLista.Insert(2, 9);

            //Remove elimina un elemento
            //eliminamos el numero 8 si hay varios elemenmtos iguales, elimina el primero.
            miLista.Remove(8);

            //RemoveAt - Elimina el elemento en la posicion que le digamos
            miLista.RemoveAt(0);

            //ElementAt - devuelve el elemento en cierta posiscion
            miLista.ElementAt(0);

            foreach(int recorrer in miLista)
            {
                Console.WriteLine(recorrer);
            }

            */

            //Constructor alumno
            ClsAlumno alumno = new ClsAlumno(2,'A');


            ClsAsignatura asignaturaUno = new ClsAsignatura();
            asignaturaUno.Nombre = "Matematicas";
            asignaturaUno.Nota = 4;
            //Añadimos una asignatura a la lista de asignaturas de mi alumno
            alumno.Asignaturas.Add(asignaturaUno);

            ClsAsignatura asignaturaDos = new ClsAsignatura();
            asignaturaDos.Nombre = "Lengua";
            asignaturaDos.Nota = 10;
            //Añadimos una asignatura a la lista de asignaturas de mi alumno
            alumno.Asignaturas.Add(asignaturaDos);

            //Count Entrega un dato int con la cantidad deasignaturas
            Console.WriteLine(alumno.Asignaturas.Count);

            //Imprimimos promedio de alumno
            Console.WriteLine(alumno.CalcularPromedio());


            Console.ReadKey();
        }
    }
}
