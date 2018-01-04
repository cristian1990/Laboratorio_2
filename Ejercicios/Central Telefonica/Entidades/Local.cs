using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        #region "Atributos"
        protected float _costo;
        #endregion

        #region "Propiedades"
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        #endregion

        #region "Metodos"
        private float CalcularCosto()
        {
            float _valorLlamada = (_costo * Duracion);
            return _valorLlamada ;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LLAMADA LOCAL");
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("COSTO          : " + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region "Constructores"
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {  }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this._costo = costo;
        }
        #endregion
    }
}
