using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Metodos
{
    class Suma
    {
        //para hacer sobrecarga de metodo mejor usar "static"
        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sumar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
