using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 5;
            int[] numeros = new int[cant];

            // ASIGNACION 1
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;
            //Console.Write("El elemento 2 es: " + numeros[1]);
      

            //RECORRER ARRAY
            /*
            for(int posicion = 0; posicion < numeros.Length; posicion++) //numeros.Length (Hasta el final del array)
            {
                Console.WriteLine("Posicion " + (posicion + 1) + ": " + numeros[posicion]);
            }
            */

            //RECORRER ARRAY CON FOREACH (Permite recorrer un array de forma secuencial, hasta el final)
            foreach(int numero in numeros)
            {
                Console.Write(numero + ",");

            }


            Console.ReadKey();

        }
    }
}
