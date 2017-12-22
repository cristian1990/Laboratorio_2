using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //la clase ClsClientesVentas hereda los atributos y metodos de la clase ClsClientes.
    public class ClsClientesVentas : ClsClientes
    {
        //refactorizamos y encapsulamos los atributos con "ctrl + r + e"
        private string _RFC;
        private string _direccion;
        private string _localidad;
        private string _provincia;
        private bool _esCredito;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Localidad { get => _localidad; set => _localidad = value; }
        public string Provincia { get => _provincia; set => _provincia = value; }
        public bool EsCredito { get => _esCredito; set => _esCredito = value; }
    }
}
