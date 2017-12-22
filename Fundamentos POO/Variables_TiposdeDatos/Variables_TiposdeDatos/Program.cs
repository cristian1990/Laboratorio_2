using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_TiposdeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int suma;

            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            suma = numero1 + numero2;

            Console.WriteLine("La suma es: "+ suma);

            Console.ReadKey();
        }
    }
}
