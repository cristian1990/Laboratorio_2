using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public abstract class Prestamo
    {
        #region "Atributos"
        protected float _monto;
        protected DateTime _vencimiento;
        #endregion

        #region "Propiedades"
        public float Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public DateTime Vencimiento
        {
            get { return _vencimiento; }
            set
            {
                if (value > DateTime.Now)
                {
                    _vencimiento = value;
                }
                else
                {
                    _vencimiento = DateTime.Now.Date;
                }
            }
        }
        #endregion

        #region "Metodos"
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("PRESTAMO PERSONAL");
            str.AppendFormat("Monto: {0}\n", this.Monto);
            str.AppendFormat("Vencimiento: {0}\n", this.Vencimiento);

            return str.ToString();

        }

        public static int OrdenarPorFecha(Prestamo prestamo1, Prestamo prestamo2)
        {
            int retorno = 0;

            if (prestamo1._vencimiento > prestamo2._vencimiento)
                retorno = 1;

            if (prestamo1._vencimiento < prestamo2._vencimiento)
                retorno = -1;

            return Convert.ToInt32(retorno);
        }
        #endregion

        #region "Constructores"
        public Prestamo(float monto, DateTime vencimiento)
        {
            this._monto = monto;
            this._vencimiento = vencimiento;
        }
        #endregion
    }
}
