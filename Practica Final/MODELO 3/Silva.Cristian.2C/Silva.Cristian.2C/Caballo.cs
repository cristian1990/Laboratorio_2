using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Caballo : Animal
    {
        #region "Atributos"
        private string _nombre;
        private static int _patas;
        #endregion

        #region "Metodos"
        public string MostrarCaballo()
        {
            return string.Format("Nombre: {0} Patas: {1}", _nombre, _patas);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Caballo)
            {
                if ((Caballo)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        static Caballo()
        {
            _patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima) : base (_patas, velocidadMaxima)
        {
            this._nombre = nombre;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Caballo caballo1, Caballo caballo2)
        {
            bool retorno = false;
            if (caballo1._nombre == caballo2._nombre)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Caballo caballo1, Caballo caballo2)
        {
            return !(caballo1 == caballo2);
        }
        #endregion
    }
}
