using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Jugo : Producto
    {
        #region "Enumeradores"
        public enum ESaborJugo { Pasable, Bebible, Asqueroso};
        #endregion

        #region "Atributos"
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get { return _precio * 0.40f; }
        }
        #endregion

        #region "Metodos"
        public override string Consumir()
        {
            return string.Format("Bebible");
        }

        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("SABOR: {0}\n\n", _sabor);

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarJugo();
        }
        #endregion

        #region "Constructores"
        static Jugo()
        {
            DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor) : base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }
        #endregion
    }
}
