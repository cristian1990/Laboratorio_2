using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    //Lo defino afuera de la clase para que se conozca en todo el namespace.
    //Definimos el delegado con las caracteristicas que nos intereza (Que deben ser las mismas de los metodos delegados).
    public delegate void MiDelegado(string m);

    class Program
    {
        static void Main(string[] args)
        {
            //El metodo delegador no tiene codigo.
            //Delegados: un metodo delega el proceso a otro. Invocamos de manera indirecta un metodo.
            //Los parametros del metodo delegador y el metodo delegado, tiene que ser el mismo.
            //Delegado = Tiene que tener el:
            // * Mismo tipo de retorno
            // * Misma cantidad de parametros
            // * Mismos tipos de parametro


            //Creamos un objeto del delegado y lo referenciamos a un metodo.
            MiDelegado delegado = new MiDelegado(Radio.MetodoRadio);  // Lo referenciamos al "MetodoRadio" que pertenece a la clase Radio.

            //Ahora por medio del delegado hacemos uso del metodo
            delegado("Hola a todos"); //Invoco a "delegado" que tiene referencia a "MetodoRadio" por eso se ejecuta MetodoRadio.


            //Cambiamos la referencia al Metodo
            delegado = new MiDelegado(Pastel.MostrarPastel); //Ahora el que se ejecuta es "Mostrar Pastel" si llamamos a delegado

            //Ahora invocamos al metodo "MostrarPastel"
            delegado("Feliz cumpleaños");


            Console.ReadKey();

        }
    }
}
