using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Perro : Mascota
    {
        #region "Atributos"
        private int _edad;
        private bool _esAlfa;
        #endregion

        #region "Propiedades"
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public bool EsAlfa
        {
            get { return _esAlfa; }
            set { _esAlfa = value; }
        }
        #endregion

        #region "Metodos"
        public static explicit operator int(Perro perro)
        {
            return perro._edad;
        }

        protected override string Ficha()
        {
            string retorno = "";

            if(_esAlfa == true)
            {
                retorno = string.Format("{0} {1} alfa de la manada {2}", Nombre, Raza, Edad);
            }

            if (_esAlfa == false)
            {
                retorno = string.Format("{0} {1} {2}", Nombre, Raza, _edad);
            }

            return retorno;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Perro)//si mi obj es Gato
            {
                if ((Perro)obj == this) //si obj es igual a mi instancia actual
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion

        #region "Constructores"
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this._edad = 0;
            this._esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }
        #endregion

        #region "Sobrecargas"
        public static bool operator ==(Perro perro1, Perro perro2)
        {
            bool retorno = false;
            if (perro1.Nombre == perro2.Nombre && perro1.Raza == perro2.Raza)
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
