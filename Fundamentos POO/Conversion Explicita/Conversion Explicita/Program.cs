using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Explicita
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion custom de tipo
            NumeroComplejo numComplejo = new NumeroComplejo(10,354546);

            //no se puede
            //NumerosReales numReal = numComplejo;

            NumerosReales numReal2 = (NumerosReales)numComplejo;

            Console.WriteLine(numReal2);
            Console.WriteLine(numComplejo);

            Console.ReadKey();
        }
    }
}
