using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(new List<int> { 1, 2 });
            Console.WriteLine(vector.Componentes.ToString());
            Console.WriteLine(vector.Dimension);
            vector[0] = 5;
            Console.WriteLine("Indexador");
            Console.WriteLine(vector[0]);
            Console.WriteLine(vector[1]);
            Console.WriteLine(vector.Componentes[0]);
            Console.ReadKey();
        }
    }
}
