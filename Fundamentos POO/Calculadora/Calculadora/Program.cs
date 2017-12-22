using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedimos a usuario que hacer
            Console.WriteLine("Bienvenidos a la calculadora 2.0");

            //Environment.NewLine  (sirve para hacer saltos de linea)
            Console.WriteLine("Introduzca la operacion que desea hacer: "
            + Environment.NewLine + "1. Suma" + Environment.NewLine + "2. Resta" + Environment.NewLine + "3. Multiplicacion" + Environment.NewLine + "4. Division");

            int operacionaRealizar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el primer numero");
            double numeroUno = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo numero");
            double numeroDos = Convert.ToDouble(Console.ReadLine());

            double resultado;

            if(operacionaRealizar == 1)
            {
                resultado = numeroUno + numeroDos;
            }
            else if(operacionaRealizar == 2)
            {
                resultado = numeroUno - numeroDos;
            }
            else if(operacionaRealizar == 3)
            {
                resultado = numeroUno * numeroDos;
            }
            else if(operacionaRealizar == 4)
            {
                resultado = numeroUno / numeroDos;
            }
            else
            {
                Console.WriteLine("La operacion no es correcta");
                return;
            }

            Console.WriteLine("El resultado es: " + resultado);

            Console.ReadKey();
        }
    }
}
