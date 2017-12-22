using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Genericos
{
    public class Empresa
    {
        string _razonSocial;

        public string Direccion
        {
            get {return this._razonSocial; }
            set {this._razonSocial = value; }
        }

        public Empresa(string razonSocial)
        {
            this._razonSocial = razonSocial;
        }
    }
}
