using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mostrarMenu();
            int opcionElegida = obtenerNumero();

            Console.WriteLine("Introduce el primer numero");
            double numUno = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");
            double numDos = Convert.ToDouble(Console.ReadLine());

            switch(opcionElegida)
            {
                case 1:
                    double suma = Sumar(numUno, numDos);
                    Console.WriteLine("La suma es: " + suma);
                    break;
                case 2:
                    double resta = Restar(numUno, numDos);
                    Console.WriteLine("La resta es: " + resta);
                    break;
                case 3:
                    double multiplicacion = Multiplicacion(numUno, numDos);
                    Console.WriteLine("La multiplicacion es: " + multiplicacion);
                    break;
                case 4:
                    double division = Division(numUno, numDos);
                    Console.WriteLine("La division es: " + division);
                    break;
            }


            Console.ReadKey();
        }

        static void mostrarMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Suma ");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - Division");
        }

        static int obtenerNumero()
        {
            Console.WriteLine("\nIntroduzca una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        static double Sumar(double num1, double num2)
        {
            double suma = num1 + num2;
            return suma;
        }

        static double Restar(double num1, double num2)
        {
            double resta = num1 - num2;
            return resta;
        }

        static double Multiplicacion(double num1, double num2)
        {
            double multiplicacion = num1 * num2;
            return multiplicacion;
        }

        static double Division(double num1, double num2)
        {
            double division = num1 / num2;
            return division;
        }

    }
}
