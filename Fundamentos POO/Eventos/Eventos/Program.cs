using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculos = new Calculos();

            calculos.CalculoFinalizado += calculo_CalculoFinalizado;

            Console.WriteLine("Primer paso");

            calculos.Calcular();

            Console.ReadKey();
        }

        static void calculo_CalculoFinalizado()
        {
            Console.WriteLine("Resultado ejecutado");
        }
    }
}
