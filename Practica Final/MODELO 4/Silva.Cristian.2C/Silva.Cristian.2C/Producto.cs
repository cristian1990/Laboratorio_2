using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public abstract class Producto
    {
        #region "Enumeradores"
        public enum EMarcaProducto { Favorita, Pitusas, Diversión, Naranjú, Manaos, Swift};
        public enum ETipoProducto { Galletita, Gaseosa, Jugo, Harina, Todos};
        #endregion

        #region "Atributos"
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        #endregion

        #region "Propiedades"
        public abstract float CalcularCostoDeProduccion
        {
            get;
        }

        public EMarcaProducto Marca
        {
            get { return _marca; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        public int CodigoBarra
        {
            get { return _codigoBarra; }
        }
        #endregion

        #region "Metodos"
        public virtual string Consumir()
        {
            return string.Format("Parte de una mezcla.");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Producto)
            {
                if ((Producto)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static explicit operator int(Producto producto)
        {
            return producto._codigoBarra;
        }

        public static implicit operator string(Producto producto)
        {
            return MostrarProducto(producto);
        }

        private static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MARCA: " + producto._marca);
            sb.AppendLine("CODIGO DE BARRAS: " + producto._codigoBarra);
            sb.AppendFormat("PRECIO: " + producto._precio);

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarProducto(this);
        }
        #endregion

        #region "Constructores"
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            bool retorno = false;
            if (prod1._marca == prod2._marca && prod1._codigoBarra == prod2._codigoBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            bool retorno = false;
            if (prodUno._marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }
        #endregion
    }
}
