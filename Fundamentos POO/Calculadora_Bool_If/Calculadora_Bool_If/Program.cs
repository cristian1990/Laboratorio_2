using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Bool_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int numUno;
            int numDos;
            int Resultado = 0;

            Console.WriteLine("Bienvenidos a la calculadora 2.0\n");

            Console.WriteLine("Introduzca que operacion quiere hacer");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. RESTA");
            Console.WriteLine("3. MULTIPLICACION");
            Console.WriteLine("4. DIVISION\n");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el primer numero");
            numUno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo numero");
            numDos = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Resultado = numUno + numDos;
                    break;
                case 2:
                    Resultado = numUno - numDos;
                    break;
                case 3:
                    Resultado = numUno * numDos;
                    break;
                case 4:
                    if(numDos != 0)
                    {
                        Resultado = numUno / numDos;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                        Console.ReadKey();
                        return; //Hace que se salga del programa 
                    }
                    break;
            }

            Console.WriteLine("El resultado es: " + Resultado);

            Console.ReadKey();
        }
    }
}
