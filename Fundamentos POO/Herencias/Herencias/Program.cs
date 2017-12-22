using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseHija Herencia = new ClaseHija();

            //la ClaseHija heredo los metodos de clase padre
            Herencia.Saludar();

            Console.ReadKey();
        }
    }
}
