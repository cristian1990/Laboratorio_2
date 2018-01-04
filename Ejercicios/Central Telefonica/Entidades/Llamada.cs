using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Llamada
    {

        #region "Enumeradores"
        public enum ETipoLlamada { Local, Provincial, Todas}
        #endregion

        #region "Atributos"
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region "Propiedades"
        public float Duracion
        {
            get { return _duracion; }
        }

        public string NroDestino
        {
            get { return _nroDestino; }
        }

        public string NroOrigen
        {
            get { return _nroOrigen; }
        }

        public abstract float CostoLlamada
        {
            get;
        }
        #endregion

        #region "Metodos"
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DURACION       : " + _duracion);
            sb.AppendLine("NUMERO DESTINO : " + _nroDestino);
            sb.AppendLine("NUMERO ORIGEN  : " + _nroOrigen);

            return sb.ToString();
                
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
                retorno = 1;
            else if (llamada1.Duracion < llamada2.Duracion)
                retorno = -1;
            return retorno;
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Equals(llamada2))
            {
                if (llamada1.NroOrigen == llamada2.NroOrigen && llamada1.NroDestino == llamada2.NroDestino)
                    return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            return (obj is Centralita);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
        #endregion

        #region "Constructores"
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }
        #endregion
    }
}
