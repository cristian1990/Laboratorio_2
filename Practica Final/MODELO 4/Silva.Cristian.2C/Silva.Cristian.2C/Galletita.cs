using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Galletita : Producto
    {
        #region "Atributos"
        protected float _peso;
        protected static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get { return _precio * 0.33f; }
        }
        #endregion

        #region "Metodos"
        public override string Consumir()
        {
            return string.Format("Comestible");
        }

        private string MostrarGalletita(Galletita galletita)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("PESO: {0}\n\n", _peso);

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarGalletita(this);
        }
        #endregion

        #region "Constructores"
        static Galletita()
        {
            DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso) : base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }
        #endregion
    }
}
