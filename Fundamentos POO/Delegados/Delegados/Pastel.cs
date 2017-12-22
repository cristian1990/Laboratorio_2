using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Pastel
    {
        // Este metodo actuara como delegado
        // Void (string A) {} - Mismas caracteristicas que el metodo "MetodoRadio"
        public static void MostrarPastel(string anuncio)  //static es necesario para que podamos usar el delegado, ya que nos permite llevar a cabo la invocacion aun si no esxiste una instancia de la clase radio
        {
            Console.ForegroundColor = ConsoleColor.Red;  //Color de texto rojo
            Console.WriteLine("\nEstamos en la clase Pastel");
            Console.WriteLine("El pastel llevara el mensaje de {0}:", anuncio);
        }
    }
}
