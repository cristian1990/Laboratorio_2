using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Harina : Producto
    {
        #region "Enumeradores"
        public enum ETipoHarina { Integral, TresCeros, CuatroCeros};
        #endregion

        #region "Atributos"
        private ETipoHarina _tipo;
        protected static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get { return _precio * 0.60f; }
        }
        #endregion

        #region "Metodos"
        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("TIPO: {0}\n\n", _tipo);

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarHarina();
        }
        #endregion

        #region "Constructores"
        static Harina()
        {
            DeConsumo = false;
        }

        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo) : base(codigo, marca, precio)
        {
            this._tipo = tipo;
        }
        #endregion
    }
}
