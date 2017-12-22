using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Polimorfismo = Capacidad de una clase de utilizar sus metodos de distinta forma.

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguraRectangulo rectangulo = new FiguraRectangulo();
            rectangulo.Area(10,20);

            FiguraTriangulo triangulo = new FiguraTriangulo();
            triangulo.Area(10,20);

            Console.ReadKey();


        }
    }
}
