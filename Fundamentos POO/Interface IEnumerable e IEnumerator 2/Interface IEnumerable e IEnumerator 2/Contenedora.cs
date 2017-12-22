using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREAMOS NUESTRA PROPIA IMPLEMENTACION PARA IENUMERABLE E IENUMERATOR

namespace Interface_IEnumerable_e_IEnumerator_2
{
    class Contenedora : IEnumerable  //Implementa a IEnumerable
    {
        private int[] valores = new int[10];

        public Contenedora()
        {
            //Relleno el arreglo con el cuadrado de cada indice
            for (int i = 0; i < 10; i++)
                valores[i] = i * i;
        }

        //Implementamos el GetEnumerator necesario por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()  //Regresa un objeto de tipo IEnumerator
        {
            //Instanciamos el enumerador y lo regresamos
            return (new ContenedorEnum(valores));
        }     
    }


    //Clase encargada de recorrer la estructura de datos
    class ContenedorEnum : IEnumerator //Como implementa a IEnumerator es necesario usar los comportamientos "MoveNext", "Reset" y "Current"
    {
        public int[] arreglo;
        private int posicion = -1; //Necesito poner -1 por el "MoveNext" se mueve al siguiente elemento

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        //En este metodo vamos avanzando elemento a elemento en nuestra estructura de datos
        public bool MoveNext() //Se mueve al indice 0
        {
            posicion++;
            if (posicion < arreglo.Length) //Si posicion es menor que la longitud del arreglo
                return true;  //Si existe pasa el siguiente elemento y retorna "true"
            else
                return false; //Si no existe retorna "false"
        }

        //El comportamiento "Reset()" mandamos al inicio de la estructura de datos parea que podamos volver a leerla
        public void Reset()
        {
            posicion = -1;  //Volvemos al inicio
        }

        //El comportamiento "Current" nos regresa algo de tipo object - Toma el elemento en el que estamos colocxados y lo regresa al exterior
        //Seria idela usar Excepciones
        public object Current
        {
            get
            {
                return arreglo[posicion]; //Se regresa como tipo object -  es necesario hacer un TypeCast para regresarlo al tipo adecuado.
            }
        }


    }
}
