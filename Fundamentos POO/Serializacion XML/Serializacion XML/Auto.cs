using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_XML
{
    //La clase es publica 
    [Serializable] //Indicamos que la clase a continuacion es seriabizable.
    public class Auto
    {
        private double _costo;
        private string _modelo;

        //Agregamos propiedades
        public double Costo
        {
            get {return _costo; }
            set {_costo = value; }
        }

        public string Modelo
        {
            get {return _modelo; }
            set {_modelo = value; }
        }

        //Cuando usamos serializacion XML nuestro constructor no puede tener parametros
        //constructor sin parametros
        public Auto()
        {
            //Inicializamos los datos
            _costo = 10000;
            _modelo = "Fiat";
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
