using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Estante
    {
        #region "Atributos"
        protected sbyte _capacidad;
        protected List<Producto> _productos;
        #endregion

        #region "Propiedades"
        public float ValorEstanteTotal
        {
            get { return GetValorEstante(); }
        }
        #endregion

        #region "Metodos"
        public List<Producto> GetProductos()
        {
            return _productos;
        }

        public float GetValorEstante()
        {
            return GetValorEstante(Producto.ETipoProducto.Todos);
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float resultado = 0;

            foreach(Producto producto in GetProductos())
            {
                switch(tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (producto is Galletita)
                            resultado += producto.Precio;
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (producto is Gaseosa)
                            resultado += producto.Precio;
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (producto is Harina)
                            resultado += producto.Precio;
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (producto is Jugo)
                            resultado += producto.Precio;
                        break;
                    case Producto.ETipoProducto.Todos:
                            resultado += producto.Precio;
                        break;
                }
            }
            return resultado;
        }

        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("La capacidad es: " + estante._capacidad);

            foreach(Producto producto in estante.GetProductos())
            {
                sb.AppendFormat(producto.ToString());
            }
            return sb.ToString();
        }   

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Estante)
            {
                if ((Estante)obj == this) 
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        private Estante()
        {
            _productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Estante estante, Producto producto)
        {
            bool retorno = false;

            foreach (Producto auxProducto in estante._productos)
            {
                if (auxProducto == producto)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            if ((estante.GetProductos().Count < estante._capacidad) && (estante != producto))
            {
                estante.GetProductos().Add(producto);
                return true;
            }
            return false;
        }

        public static Estante operator -(Estante estante, Producto producto)
        {
            foreach (Producto auxProducto in estante._productos)
            {
                if (auxProducto == producto)
                {
                    estante._productos.Remove(auxProducto);
                    break;
                }
            }

            return estante;
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {

            for (int i = 0; i < e.GetProductos().Count; i++)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (e.GetProductos()[i] is Galletita)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (e.GetProductos()[i] is Gaseosa)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (e.GetProductos()[i] is Harina)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (e.GetProductos()[i] is Jugo)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Todos:
                        e.GetProductos().Clear();
                        break;
                }
            }
            return e;
        }

        #endregion
    }
}
