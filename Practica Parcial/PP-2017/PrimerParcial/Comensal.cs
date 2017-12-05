using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    public abstract class Comensal
    {
        #region "Atributos"
        private string _apellido;
        private string _nombre;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get { return _nombre; }
        }

        public string Apellido
        {
            get { return _apellido; }
        }
        #endregion

        #region "Metodos"
        public virtual string Mostrar()
        {
            return string.Format("NOMBRE: {0} APELLIDO: {1}", _nombre, _apellido);
        }
        #endregion

        #region "Constructores"
        public Comensal(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion
    }
}
