using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Resta : IOperacion
    {
        private double resta = 0;
        private ArrayList resultados = new ArrayList();

        //Metodos a implementar
        public void Calcular(double a, double b) //Tiene que tener las mismas caracteristicas (Identico) que el metodo en la Interfaz.
        {
            resta = a - b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la resta es: es {0}\n", resta);
            resultados.Add(resta);
        }

        //Metodos propios de la clase
        public void MuestraResultado()
        {
            foreach (double res in resultados)
            {
                Console.WriteLine(res);
            }
        }
    }
}
