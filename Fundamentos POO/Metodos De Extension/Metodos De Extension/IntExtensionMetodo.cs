using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Extension
{
    //siempre static, al igual que el metodo
    public static class IntExtensionMetodo
    {
        //this int valor = indica a cual tipo le voy a agregar el metodo
        //int exponente = parametro que le pasamos al metodo extension
        public static double ElevadoALa(this int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }

        //Metodo sin parametros
        //this int valor = indica a cual tipo le voy a agregar el metodo
        public static double Doble(this int valor)
        {
            return valor * 2;
        }

        public static bool EsPar(this int valor)
        {
            if (valor % 2 == 0)
                return true;
            else
                return false;
        }

        //Tambien sirve para inferfaces
        // se aplica a las clases que derivan de la interface
        public static void Sonido(this ISaludador saludo)
        {
            Console.Beep();
        }
    }
}
