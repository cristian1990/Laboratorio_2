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

            //conversion explicita
            NumerosReales numReal2 = (NumerosReales)numComplejo;
            Console.WriteLine(numReal2);


            //conversion implicita
            NumerosReales numReal1 = new NumerosReales(23.5151);
            NumeroComplejo numComp = numReal1; 
            Console.WriteLine(numComp);

            Console.ReadKey();
        }
    }
}
