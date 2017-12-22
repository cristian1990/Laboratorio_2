using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Anonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos tipos anonimos
            // Crea un tipo temporal con atributos, propiedades, to string

            // Creamos el tipo anonimo
            Console.WriteLine("\nImprimimos todos los atributos de miCompu");
            var miCompu = new { Procesador = "I7", Memoria = 16, Graficos = "Intel" };

            Console.WriteLine(miCompu);

            //Imprimimos un atributo
            Console.WriteLine("\n\nImprimimos un atributo");
            Console.WriteLine("La compu tiene {0} GB de memoria", miCompu.Memoria);

            //No podemos modificar el atributo, es de solo lectura
            //miCompu.Graficos = "nvidia";

            Console.ReadKey();
        }
    }
}
