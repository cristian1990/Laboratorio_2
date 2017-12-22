using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = 5;

           Console.WriteLine(num.ElevadoALa(3));

            Console.WriteLine(num.Doble());

            Console.WriteLine(num.EsPar());

            //con la interface
            MiInt numero = new MiInt(7);
            numero.Sonido();

           Console.ReadKey();

        }
    }
}
