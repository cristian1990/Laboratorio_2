using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        #region "Enumeradores"
        public enum EFranja { Franja_1, Franja_2 , Franja_3 }
        #endregion

        #region "Atributos"
        protected EFranja _franjaHoraria;
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
            float valorLlamada = 0;

            if(_franjaHoraria == EFranja.Franja_1)
            {
                valorLlamada = Duracion * 0.99f;
            }
            else if (_franjaHoraria == EFranja.Franja_2)
            {
                valorLlamada = Duracion * 1.25f;
            }
            else if (_franjaHoraria == EFranja.Franja_3)
            {
                valorLlamada = Duracion * 0.66f;
            }
            return valorLlamada;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LLAMADA PROVINCIAL");
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("COSTO LLAMADA  : " + this.CostoLlamada);
            sb.AppendLine("FRANJA HORARIA : " + this._franjaHoraria.ToString());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region "Constructores"

        public Provincial(string origen, EFranja miFranja, float duracion, string destino) : base(duracion, origen, destino)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(EFranja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {  }

        #endregion
    }
}
