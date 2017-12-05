using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class PrestamoPesos : Prestamo
    {
        #region "Atributos"
        private float _porcentajeInteres;
        #endregion

        #region "Propiedades"
        public float Interes
        {
            get { return CalcularInteres(); }
        }
        #endregion

        #region "Metodos"
        private float CalcularInteres()
        {
            return base.Monto + (base.Monto * _porcentajeInteres / 100);
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("INTERES: " + _porcentajeInteres);

            return sb.ToString();
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int diasExtendidos = (nuevoVencimiento.Day - Vencimiento.Day);

            for (int i = 0; i < diasExtendidos; i++)
                Monto += (Monto * 0.25f);

            Vencimiento = nuevoVencimiento;
        }

        #endregion

        #region "Constructores"
        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this._porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamos, float porcentajeInteres) : this(prestamos.Monto, prestamos.Vencimiento, porcentajeInteres)
        { }
        #endregion
    }
}
