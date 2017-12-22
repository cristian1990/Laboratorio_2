using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Genericas
{
    // "T" representa al tipo con el que se trabaja en un momento dado 
    class CTipos<T>
    {
        //Creamos atributos del tipo "T" - Pero podria utilizar atributos INT, DOUBLE, STRING
        private T x;
        private T y;

        //Podemos recibir parametros del tipo "T"
        public CTipos(T pX, T pY)
        {
            x = pX;
            y = pY;
        }

        public override string ToString()
        {
            return String.Format("x={0}, y={1}", x, y);
        }


        //No es obligatorio, pero conviene saber como funciona
        public void Reset()
        {
            // Colocamos el valor de default para el tipo "T" - inicializamos
            // Numericos 0
            // Referencias NULL

            x = default(T); //default nos regresa el valor de default de un tipo en particular (INT, DOUBLE, CLASES)
            y = default(T); //dependiendo del tipo que se encuentre en "T" va a ser el valor de default de "y"
        }


        //De acuerdo a el tipo, puedo elegir trabajar de diferente manera - identifico el tipo con TYPEOF
        public void EncuentraTipo()
        {
            if (typeof(T) == typeof(int))
            {
                Console.WriteLine("Trabajo como entero");
            }
            else if (typeof(T) == typeof(float))
            {
                Console.WriteLine("Trabajo como Float");
            }
            else if (typeof(T) == typeof(double))
            {
                Console.WriteLine("Trabajo como Double");
            }
            else if (typeof(T) == typeof(string))
            {
                Console.WriteLine("Trabajo como String");
            }
            else
            {
                Console.WriteLine("Soy un tipo raro");
            }

        }

    }
}
