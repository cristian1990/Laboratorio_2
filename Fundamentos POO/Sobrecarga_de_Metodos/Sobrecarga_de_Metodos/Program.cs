using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //El compilador automaticamente detecta que metodo correr mediante sus parametros
            int res = Suma.Sumar(10, 20, 30);
            Console.WriteLine(res);

            int res2 = Suma.Sumar(10, 20);
            Console.WriteLine(res2);

            Console.ReadKey();
        }
    }
}
