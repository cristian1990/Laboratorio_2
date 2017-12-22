using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Sirve para indicar una serie de comportamientos que puede tener una clase.
    //Calculadora hace una operacion aritmetica.
    //Concepto abstracto = realiza una operacion y da un resultado.
    //No decimos como se hacen las cosas, si no que se debe hacer.

    public interface IOperacion
    {
        //Unicamente se puede colocar los prototipos de los metodos. -> TIPO (que regresa) NOMBRE (del metodo) PARAMETROS (que tiene que utilizar)
        //No se coloca nada de codigo, la interfas es un concepto abstracto.
        //No se puede colocar variables ni codigo.

        void Calcular(double a, double b); //comportamiento Calcular - del concepto de operacion.

        void Mostrar();

    }
}
