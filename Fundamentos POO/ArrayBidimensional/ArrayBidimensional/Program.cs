using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array bidimensional
            int cantX = 3;
            int cantY = 3;
            int[,] numeros = new int[cantX, cantY];
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[2, 1] = 50;
            numeros[0, 2] = 60;

            numeros[0, 0] = 70;
            numeros[1, 1] = 80;
            numeros[2, 2] = 90;

            for(int posicionX = 0; posicionX < cantX; posicionX++)
            {
                for(int posicionY = 0; posicionY < cantY; posicionY++)
                {
                    Console.Write(numeros[posicionX, posicionY] + "\t");
                }

                Console.Write(Environment.NewLine);

            }
            Console.ReadKey();
        }
    }
}
