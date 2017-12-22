using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Radio
    {
        //Este metodo actuara como delegado
        // Void (string m) {}  - Mismas caracteristicas que el metodo "MostrarPastel"
        public static void MetodoRadio(string mensaje)  //static es necesario para que podamos usar el delegado, ya que nos permite llevar a cabo la invocacion aun si no esxiste una instancia de la clase radio
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //Color de letra amarillo
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Este es tu mensaje {0}", mensaje);
        }
    }
}
