using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Humano : Animal
    {
        #region "Atributos"
        private string _apellido;
        private string _nombre;
        static int _piernas;
        #endregion

        #region "Metodos"
        public string MostrarHumano()
        {
            return string.Format("Nombre: {0} Apellido: {1} Piernas: {2}", _nombre, _apellido, _piernas);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Humano)
            {
                if ((Humano)obj == this) 
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        static Humano()
        {
            _piernas = 2;
        }

        public Humano (int velocidadMaxima) : base(_piernas, velocidadMaxima)
        { }

        public Humano(string nombre, string apellido, int velocidadMaxima) : this (velocidadMaxima)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Humano humano1, Humano humano2)
        {
            bool retorno = false;
            if (humano1._nombre == humano2._nombre && humano1._apellido == humano2._apellido)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Humano humano1, Humano humano2)
        {
            return !(humano1 == humano2);
        }
        #endregion
    }
}
