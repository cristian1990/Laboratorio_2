using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Division div = new Division();
            int res = 0;
            try
            {
                res = div.Dividir(30, 0);
            }
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("No se puede dividir por cero");
            //}

            catch (DividirCeroException)
            {
                Console.WriteLine("No se puede dividir por cero, ingrese otro numero");
            }

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
