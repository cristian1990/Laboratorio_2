using System;
using System.Collections; //Sacamos el Generic para usar Arraylist
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_2
{
    class Refrigerador
    {
        //Aqui van los delegador
        public delegate void DReservasBajas(int pKilos); //No deberian ser publicos
        public delegate void DDescongelado(int pGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;

        //Aqui estan las variables que usaremos para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;
        
        public Refrigerador(int pKilos, int pGrados)
        {
            //Coloca los valores iniciales del refrigerador
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        //Estos metodos permiten referenciar las variables
        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas = pMetodo;
        }

        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado = pMetodo;
        }

        //Propiedades necesarias
        public int Kilos
        {
            get { return kilosAlimentos; }
        }

        public int Grados
        {
            get { return grados; }
        }

        public void Trabajar(int pConsumo)
        {
            //Actualizamos los kilos del refrigerador
            kilosAlimentos -= pConsumo;

            //Subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //Hay que verificar si se cumple la condicion para invocar los handlers del evento.

            //Esta es la condicion del evento para los kilos
            if(kilosAlimentos < 10)
            {
                //Invocamos el metodo
                delReservas(kilosAlimentos);
            }

            //Esta es la condicion del evento para la temperatura
            if(grados > 0)
            {
                //Invocamos el metodo
                delDescongelado(grados);
            }
        }
    }
}
