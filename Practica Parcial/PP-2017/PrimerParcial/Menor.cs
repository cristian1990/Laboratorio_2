using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    public class Menor : Comensal
    {
        #region "Enumeradores"
        public enum EMenu { Milanesa, Hamburguesa}
        #endregion

        #region "Atributos"
        private EMenu _menu;
        #endregion

        #region "Propiedades"
        public EMenu Menu
        {
            get { return _menu; }
            set { _menu = value; }
        }
        #endregion

        #region "Metodos"
        public override string Mostrar()
        {
            return string.Format("{0} {1}", base.Mostrar(), _menu);
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Menor)
            {
                if ((Menor)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        public Menor(string nombre, string apellido) : base(nombre, apellido)
        { }

        public Menor(string nombre, string apellido, EMenu menu) : this(nombre,apellido)
        {
            this._menu = menu;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Menor menor1, Menor menor2)
        {
            bool retorno = false;
            if (menor1.Nombre == menor2.Nombre && menor1.Apellido == menor2.Apellido && menor1._menu == menor2._menu)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Menor menor1, Menor menor2)
        {
            return !(menor1 == menor2);
        }
        #endregion
    }
}
