using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Perro : Animal
    {
        #region "Enumeradores"
        public enum Razas { Galgo, OvejeroAleman }
        #endregion

        #region "Atributos"
        private static int _patas;
        private Razas _raza;
        #endregion

        #region "Metodos"
        public string MostrarPerro()
        {
            return string.Format("Patas: {0} Raza: {1}", _patas, _raza);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Perro)
            {
                if ((Perro)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        static Perro()
        {
            _patas = 4;
        }

        public Perro(int velocidadMaxima) : base(_patas ,velocidadMaxima)
        { }

        public Perro(Razas raza, int velocidadMaxima) : this(velocidadMaxima)
        {
            this._raza = raza;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Perro perro1, Perro perro2)
        {
            bool retorno = false;
            if (perro1._raza == perro2._raza && perro1._velocidadMaxima == perro2._velocidadMaxima)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Perro perro1, Perro perro2)
        {
            return !(perro1 == perro2);
        }
        #endregion
    }
}
