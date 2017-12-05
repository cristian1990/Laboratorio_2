using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    public class Mesa
    {
        #region "Atributos"
        private List<Comensal> _comensales;
        private int _numero;
        private static int _capacidad;
        #endregion

        #region "Propiedades"
        public int Cantidad
        {
            get { return _capacidad; }
        }

        public List<Comensal> Comensales
        {
            get { return _comensales; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        #endregion

        #region "Metodos"
        public static implicit operator string(Mesa mesa)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Mesa: {0} Comensales {1}", mesa, mesa._numero);

            foreach(Mayor item in mesa._comensales)
            {
                sb.AppendFormat(item.ToString());
            }

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Mesa)
            {
                if ((Mesa)obj == this) 
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        static Mesa()
        {
            _capacidad = 12;
        }

        private Mesa()
        {
            _comensales = new List<Comensal>();
        }

        public Mesa(int numero) : this()
        {
            this.Numero = numero;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Mesa mesa1, Mesa mesa2)
        {
            bool retorno = false;
            if (mesa1._numero == mesa2._numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Mesa mesa1, Mesa mesa2)
        {
            return !(mesa1 == mesa2);
        }

        public static Mesa operator +(Mesa mesa, Comensal comensal)
        {
            if(mesa._comensales.Count() < _capacidad)
            {
                foreach (Comensal item in mesa._comensales)
                {
                    if (item == comensal)
                    {
                        return mesa;
                    }
                }
                mesa._comensales.Add(comensal);
            }
            return mesa;
        }
        #endregion
    }
}
