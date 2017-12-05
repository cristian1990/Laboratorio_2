using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    public class Mayor : Comensal
    {
        #region "Enumeradores"
        public enum EBebidas {Agua, Cerveza, Vino,Gaseosa }
        #endregion

        #region "Atributos"
        private EBebidas _bebida;
        #endregion

        #region "Propiedades"
        public EBebidas Bebida
        {
            get { return _bebida; }
        }
        #endregion

        #region "Metodos"
        public static explicit operator string(Mayor mayor)
        {
            return string.Format("{0} BEBIDA: {1}", mayor.Mostrar(), mayor._bebida);
        }

        public override string ToString()
        {
            return (string)this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Mayor)
            {
                if ((Mayor)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        public Mayor(string nombre, string apellido, EBebidas bebida) : base(nombre, apellido)
        {
            this._bebida = bebida;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Mayor mayor1, Mayor mayor2)
        {
            bool retorno = false;
            if (mayor1.Nombre == mayor2.Nombre && mayor1.Apellido == mayor2.Apellido)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Mayor mayor1, Mayor mayor2)
        {
            return !(mayor1 == mayor2);
        }
        #endregion
    }
}
