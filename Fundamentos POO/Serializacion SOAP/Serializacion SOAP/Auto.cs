using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_SOAP
{
    [Serializable] //Indicamos que la clase a continuacion es seriabizable.
    class Auto
    {
        private double _costo;
        private string _modelo;

        //constructor
        public Auto(string modelo, double costo)
        {
            //Inicializamos los datos
            _costo = costo;
            _modelo = modelo;
        }

        public void MuestraInformacion()
        {
            //Mostramos la informacion necesaria
            Console.WriteLine("Tu automovil {0}", _modelo);
            Console.WriteLine("Costo {0}", _costo);
            Console.WriteLine("---------");
        }
    }
}
