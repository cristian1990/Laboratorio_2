using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemas_Clases_Genericas
{
    class Operaciones<T>
    {
        //Forma erronea de utilizar Clases genericas, como aceptan cualquier tipo, no podria sumar clase, por eso da error
        //public T Suma(T a, T b)
        //{
        //    return a + b;
        //}


        //Truco usando DYNAMIC para poder realizar las operaciones numericas
        //Usamos DYNAMIC para resolverlo, el tipo se verifica en tiempo de ejecusion y no en compilacion
        //Nos permite llevar a cabo la compilacion pero no va a evitar que tengamos problemas en tiempo de ejecucion
        public T Suma(T a, T b)
        {
            dynamic varA = a, varB = b; //En tiempo de ejecucion adquieren su tipo
            return varA + varB;
        }

        public T Resta(T a, T b)
        {
            dynamic varA = a, varB = b;
            return varA - varB;
        }

        public T Division(T a, T b)
        {
            dynamic varA = a, varB = b;
            return varA / varB;
        }

        public T Multiplicacion(T a, T b)
        {
            dynamic varA = a, varB = b;
            return varA * varB;
        }
    }
}
