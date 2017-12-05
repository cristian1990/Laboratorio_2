using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public abstract class Persona
    {
        #region "Atributos"
        private string _nombre;
        private string _apellido;

        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get { return this._nombre; }
        }

        public string Apellido
        {
            get { return this._apellido; }
        }
        #endregion

        #region "Metodos"
        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            return string.Format("{0} {1}", _nombre, _apellido);
        }
        #endregion

        #region "Constructores"
        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

    }
}
