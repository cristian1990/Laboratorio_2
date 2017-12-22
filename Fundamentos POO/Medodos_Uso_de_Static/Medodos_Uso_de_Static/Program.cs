using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medodos_Uso_de_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sin usar "static" en el metodo, necesito instanciar la clase 
            // Suma sum = new Suma();
            // int res = sum.Sumar(10, 2);


            //Usando "static" en el metodo
            int res = Suma.Sumar(10, 2);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
