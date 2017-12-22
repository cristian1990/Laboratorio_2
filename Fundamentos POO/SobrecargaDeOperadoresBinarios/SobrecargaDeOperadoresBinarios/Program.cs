using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadoresBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsImaginario img1 = new ClsImaginario(1, 2);
            ClsImaginario img2 = new ClsImaginario(10, 12);
            ClsImaginario imgRes;

            //Hacemos la suma
            imgRes = img1 + img2;

            Console.WriteLine("{0} + {1} = {2}", img1, img2, imgRes);

            Console.ReadKey();
        }
    }
}
