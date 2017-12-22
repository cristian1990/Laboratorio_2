using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{                           //Se pueden implementar varias interfaces separadas por "," asi como la clase padre.
    class Suma : IOperacion //Clase Suma tiene que implementar absolutamente todos los metodos de la interfas IOperacion.
    {
        private double suma = 0;
        private ArrayList resultados = new ArrayList();

        //Metodos a implementar
        public void Calcular(double c, double d) //Tiene que tener las mismas caracteristicas (Identico) que el metodo en la Interfaz.
        {
            suma = c + d;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la suma es: {0}\n", suma);
            resultados.Add(suma);
        }

        //Metodos propios de la clase
        public void MuestraResultado()
        {
            foreach(double sum in resultados)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
