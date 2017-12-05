using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo grupo = new Grupo("Mi Grupo");

            Perro perro1 = new Perro("Moro", "Pitbull");
            Perro perro2 = new Perro("Julio", "Cruza", 13, false);
            Perro perro3 = new Perro("Ramon", "Salchicha", 2, true);

            Gato gato1 = new Gato("Jose", "Angora");
            Gato gato2 = new Gato("Hernan", "Cruza");
            Gato gato3 = new Gato("Fer", "Siames");

            grupo += perro1;
            grupo += perro2;
            grupo += perro3;
            grupo += gato1;
            grupo += gato2;
            grupo += gato3;

            Console.WriteLine((string)grupo);

            Console.ReadKey();
        }
    }
}
