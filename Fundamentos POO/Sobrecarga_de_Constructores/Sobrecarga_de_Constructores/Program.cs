using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Podriamos usar cuanquier sobrecarga del constructor, el ide reconoce cual, dependiendo de los parametros que asignemos.

            //Usando el constructor por defecto
            Persona pers = new Persona();
            Console.WriteLine("La edad es: " + pers.edad);
            Console.WriteLine("El nombre es: " + pers.nombre);

            //Usando el constructor parametizado edad
            Persona pers2 = new Persona(35);
            Console.WriteLine("\nLa edad es: " + pers2.edad);

            //Usando el constructor parametizado edad y nombre
            Persona pers3 = new Persona(35, "Gerardo");
            Console.WriteLine("\nLa edad es: " + pers2.edad);
            Console.WriteLine("El nombre es: " + pers2.nombre);

            Console.ReadKey();

        }
    }
}
