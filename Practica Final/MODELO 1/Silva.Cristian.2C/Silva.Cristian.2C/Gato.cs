using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Gato : Mascota
    {
        #region "Constructores"
        public Gato(string nombre, string raza) : base(nombre, raza)
        { }
        #endregion

        #region "Metodos"
        protected override string Ficha()
        {
            return string.Format("Nombre {0} Raza {1}", Nombre, Raza);
        }

        public override string ToString()
        {
            return Ficha();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)//si mi obj es Gato
            {
                if ((Gato)obj == this) //si obj es igual a mi instancia actual
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Gato gato1, Gato gato2)
        {
            bool retorno = false;
            if (gato1.Nombre == gato2.Nombre && gato1.Raza == gato2.Raza)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Gato gato1, Gato gato2)
        {
            return !(gato1 == gato2);
        }
        #endregion

    }
}
