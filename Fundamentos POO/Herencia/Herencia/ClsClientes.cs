using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //ponemos identificador "public"   
    public class ClsClientes
    {
        private int _idCliente;
        private string _nombre;
        private string _apellido;

        public int IdCliente
        {
            get => _idCliente;
            set => _idCliente = value;
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }
    }
}
