using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Division : IOperacion
    {
        private double division = 0;
        private ArrayList resultados = new ArrayList();

        //Metodos a implementar
        public void Calcular(double a, double b) //Tiene que tener las mismas caracteristicas (Identico) que el metodo en la Interfaz.
        {
            division = a / b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la division es: {0}\n", division);
            resultados.Add(division);
        }

        //Metodos propios de la clase
        public void MuestraResultado()
        {
            foreach (double divi in resultados)
            {
                Console.WriteLine(divi);
            }
        }
    }
}
