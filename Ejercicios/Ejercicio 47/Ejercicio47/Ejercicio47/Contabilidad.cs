using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    //El tipo U deberá tener una restricción que indique que deberá tener un constructor 
    //por defecto(sin argumentos).
    public class Contabilidad<T,U> where T : Documento where U : Documento, new()
    {
        public List<T> _egresos;
        public List<U> _ingresos;

        public Contabilidad()
        {
            _egresos = new List<T>();
            _ingresos = new List<U>();
        }

        //El operador + entre Contabilidad y T agregá un elemento a la lista egresos.
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso) 
        {
            c._egresos.Add(egreso);
            return c;
        }

        //El operador + entre Contabilidad y U agregá un elemento a la lista ingresos.
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, U ingreso)
        {
            c._ingresos.Add(ingreso);
            return c;
        }
    }
}
