using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IEnumerable
{
    class Program
    {
        //public interface IEnumerable
        //{
        //    IEnumerator GetEnumerator(); //Comportamiento de IEnumerable, regresa un objeto que implemente a la interface IEnumerator
        //}

        //public interface IEnumerator  //Tiene los comportamientos clasicos de un iterador
        //{
        //    //Comportamientos de IEnumerator
        //    bool MoveNext();   //Es un metodo que nos permite movernos al siguiente elemento de la estructura, si existe regresa "true".
        //    object Current { get; }   //Sirve para poder leer el elemento actual en el que me encuentro, regresa algo de tipo object
        //    void Reset();   //Regresa al inicio de la estructura, para poder recorrerla nuevamente.
        //}

        static void Main(string[] args)
        {
            //Creamos la tienda
            TiendaAutos tienda = new TiendaAutos();

            //recorremos cada uno de los elementos de la estructura que expone

            foreach (Auto miAuto in tienda)  //foreach = iterador, recorre una estructura de datos
            {
                miAuto.CalcularTenencia(0.05);
                miAuto.MuestraInformacion();
            }

            Console.ReadKey();

        }
    }
}
