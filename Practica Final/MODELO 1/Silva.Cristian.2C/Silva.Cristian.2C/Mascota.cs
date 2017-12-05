using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public abstract class Mascota
    {
        #region "Atributos"
        private string _nombre;
        private string _raza;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get {return _nombre; }
        }

        public string Raza
        {
            get { return _raza; }
        }
        #endregion

        #region "Metodos"
        protected virtual string DatosCompletos()
        {
            return string.Format("Nombre {0} Raza {1}", _nombre, _raza);
        }

        protected abstract string Ficha();
        #endregion

        #region "Constructores"
        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }
        #endregion
    }
}
