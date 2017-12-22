using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Genericos
{
    public class Persona
    {
        string _nombre;

        public string Nombre
        {
            get {return this._nombre; }
            set {this._nombre = value; }
        }

        public Persona()
        {
  
        }

        public Persona(string nombre)
        {
            this._nombre = nombre;
        }


    }
}
