using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IEnumerable
{
    class Auto : IAutomovil //Implementamos la interface IAutomovil
    {
        double _costo;
        double _tenencia;
        string _modelo;

        //Constructor
        public Auto(string modelo, double costo)
        {
            //Iniciamos los datos
            this._costo = costo;
            this._modelo = modelo;
        }

        //Metodos Interfaz
        public void CalcularTenencia(double impuesto)
        {
            //Calculamos el impuesto
            _tenencia = 5000.0 + _costo * impuesto;
        }

        public void MuestraInformacion()
        {
            //Mostramos la informacion necesaria
            Console.WriteLine("Tu automovil {0}",_modelo);
            Console.WriteLine("Costo {0} Console una tenencia de {1}",_costo, _tenencia);
            Console.WriteLine("Total {0}",_costo + _tenencia);
            Console.WriteLine("--------");
        }
    }
}
