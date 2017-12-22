using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                       int numeroUno = 5;
                       int numeroDos = 7;
                       bool resultado;

                       //Resultado es true porque efectivamente 7 es mayor que 5
                       resultado = 7 > 5;
                       Console.WriteLine("Resultado es: " + resultado);
                       //Tambien lo podiamos escribir asi
                       resultado = numeroDos > numeroUno;
                       Console.WriteLine("Resultado es: " + resultado);

                       //Si intercambiamos los valores el resultado sera false porque 5 no es mayor que 7
                       resultado = 5 > 7;
                       Console.WriteLine("\nResultado es: " + resultado);
                       //Tambien lo podiamos escribir asi
                       resultado = numeroUno > numeroDos;
                       Console.WriteLine("Resultado es: " + resultado);

                       //Si comparamos numero 1 con numero 2 el resultado sera falso porque no son iguales
                       resultado = 5 == 7;
                       Console.WriteLine("\nResultado es: " + resultado);
                       //De este modo da true poque ambois numeros efectivamente son diferentes
                       resultado = 5 != 7;
                       Console.WriteLine("Resultado es: " + resultado);
           */

            Console.WriteLine("Introduce tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            
            //Si el numero ingresado es menor a 18 el valor bool va a ser true
            bool menorEdad = edad < 18; 

            if (edad < 0 || edad > 120)
            {
                Console.WriteLine("Introduzca una edad valida");
                Console.ReadKey();
                return;
            }
            //si el valor bool es true se imprime el mensaje 
            if(menorEdad) //si esto es false salta a la proxima linea
            {
                Console.WriteLine("Eres menor de edad");
            }
            else 
            {
                Console.WriteLine("Eres mayor de edad");
            }

            Console.ReadKey();
   
        }
    }
}
