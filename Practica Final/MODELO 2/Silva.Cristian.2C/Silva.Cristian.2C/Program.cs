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
            Equipo equipo = new Equipo("Huracán", new DirectorTecnico("Jorge", "Habbeger"));

            Jugador jugador1 = new Jugador("Fernando", "Pandolfi", 11, false);
            Jugador jugador2 = new Jugador("Julio", "Marchant", 8, false);
            Jugador jugador3 = new Jugador("Ezequiel", " Medran", 12, false);
            Jugador jugador4 = new Jugador("José", "Pereda", 24, false);
            Jugador jugador5 = new Jugador("Hernán", "Florentin", 6, true);
            Jugador jugador6 = new Jugador("Fernando", "Navas", 11, true);

            equipo += jugador1;
            equipo += jugador2;
            equipo += jugador3;
            equipo += jugador4;
            equipo += jugador5;
            equipo += jugador6;

            Console.WriteLine(equipo);

            Console.ReadKey();
        }
    }
}
