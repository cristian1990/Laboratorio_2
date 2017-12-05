using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Jugador : Persona
    {
        #region "Atributos"
        private bool _esCapitan;
        private int _numero;
        #endregion

        #region "Propiedades"
        public bool EsCapitan
        {
            get { return _esCapitan; }
            set {_esCapitan = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        #endregion

        #region "Metodos"
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Jugador)
            {
                if ((Jugador)obj == this) 
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static explicit operator int(Jugador jugador)
        {
            return jugador._numero;
        }

        protected override string FichaTecnica()
        {
            string retorno = "";

            if(_esCapitan == true)
            {
                retorno = string.Format("{0} {1}, capitan del equipo, camiseta numero {2}",Nombre, Apellido, _numero);
            }
            if(_esCapitan == false)
            {
                retorno = string.Format("{0} {1}, camiseta numero {2}", Nombre, Apellido, _numero);
            }

            return retorno;
        }

        public override string ToString()
        {
            return FichaTecnica();
        }
        #endregion

        #region "Constructores"
        public Jugador(string nombre, string apellido) : base (nombre, apellido)
        {
            this._numero = 0;
            this._esCapitan = false;
        }

        public Jugador(string nombre, string apellido, int numero, bool capitan) : base(nombre, apellido)
        {
            this._numero = numero;
            this._esCapitan = capitan;
        }
        #endregion

        #region "Sobrecargas"
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            bool retorno = false;
            if (jugador1.Nombre == jugador2.Nombre && jugador1.Apellido == jugador2.Apellido && jugador1._numero == jugador2._numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
        #endregion

    }
}
