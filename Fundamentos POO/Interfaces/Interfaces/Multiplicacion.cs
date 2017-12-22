using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Multiplicacion : IOperacion
    {
        private double multiplicacion = 0;
        private ArrayList resultados = new ArrayList();

        //Metodos a implementar
        public void Calcular(double a, double b) //Tiene que tener las mismas caracteristicas (Identico) que el metodo en la Interfaz.
        {
            multiplicacion = a * b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la multiplicacion es: {0}\n", multiplicacion);
            resultados.Add(multiplicacion);
        }

        //Metodos propios de la clase
        public void MuestraResultado()
        {
            foreach (double multi in resultados)
            {
                Console.WriteLine(multi);
            }
        }
    }
}
