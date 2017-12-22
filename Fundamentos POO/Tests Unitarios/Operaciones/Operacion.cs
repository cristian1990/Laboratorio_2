using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Calculos
    {
        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }


        public static int Dividir(int num1, int num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            return num1 / num2;
        }
    }
}
