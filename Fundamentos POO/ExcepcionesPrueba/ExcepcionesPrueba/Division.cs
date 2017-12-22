using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPrueba
{
    class Division
    {
        public int Dividir(int num1, int num2)
        {
            if(num2 == 0)
            {
                //throw new DivideByZeroException { };
                throw new DividirCeroException { };
            }
            return num1 / num2;
        }

    }
}
