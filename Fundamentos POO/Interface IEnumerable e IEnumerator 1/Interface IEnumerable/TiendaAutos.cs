using System;
using System.Collections; //saco generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IEnumerable
{
    class TiendaAutos
    {
        private Auto[] disponibles;

        public TiendaAutos()
        {
            disponibles = new Auto[4];

            disponibles[0] = new Auto("Soul", 220000.50);
            disponibles[1] = new Auto("Fit", 150000.70);
            disponibles[2] = new Auto("March", 170900.00);
            disponibles[3] = new Auto("Spack", 150000.00);
        }

        public IEnumerator GetEnumerator()  //Regresa un objeto de tipo IEnumerator
        {
            //Regresamos la estructura que nos intereza que recorra el foreach, esta debe implementar IEnumerator

            return disponibles.GetEnumerator();
        }
    }
}
