using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class FiguraTriangulo : FiguraRectangulo //Hereda los metodos y atributos de la clase FiguraRectangulo
    {
        //Us el mismo metodo, pero le cambio la funcionalidad
        public void Area(int bas, int altura)
        {
            Console.WriteLine("El area del rectangulo es: " + (bas * altura) / 2);
        }
    }
}
