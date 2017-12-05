using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Gaseosa : Producto
    {
        #region "Atributos"
        protected float _litros;
        protected static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get { return _precio * 0.42f; }
        }
        #endregion

        #region "Metodos"
        public override string Consumir()
        {
            return string.Format("Bebible");
        }

        private string MostrarGaseosa()
        {     
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("LITROS: {0}\n", _litros);

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarGaseosa();
        }
        #endregion

        #region "Constructores"
        static Gaseosa()
        {
            DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litro) : base(codigoBarra, marca, precio)
        {
            this._litros = litro;
        }

        public Gaseosa(Producto producto, float litros) : base(producto.CodigoBarra, producto.Marca, producto.Precio)
        {
            this._litros = litros;
        }
        #endregion
    }
}
