using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita centralita = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30.5f, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.EFranja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            centralita.Llamadas.Add(l1);
            Console.WriteLine(centralita.ToString());

            centralita.Llamadas.Add(l2);
            Console.WriteLine(centralita.ToString());

            centralita.Llamadas.Add(l3);
            Console.WriteLine(centralita.ToString());

            centralita.Llamadas.Add(l4);
            Console.WriteLine(centralita.ToString());

            centralita.OrdenarLlamadas();
            Console.WriteLine(centralita.ToString());
            Console.ReadKey();
        }
    }
}
