using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class PrestamoDolar : Prestamo
    {
        #region "Atributos"
        private PeriocidadDePagos _periocidad;
        #endregion

        #region "Propiedades"
        public float Interes
        {
            get { return CalcularInteres(); }
        }

        public PeriocidadDePagos Periocidad
        {
            get { return _periocidad; }
        }
        #endregion

        #region "Metodos"
        private float CalcularInteres()
        {
            return Monto + (Monto * (int)Periocidad / 100);
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int diasExtendidos = (nuevoVencimiento.Day - Vencimiento.Day);

            for (int i = 0; i < diasExtendidos; i++)
                Monto += 0.42f;

            Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("PERIOCIDAD: " + _periocidad);
            sb.AppendLine("INTERES: " + Interes);

            return sb.ToString();
        }
        #endregion

        #region "Constructores"
        public PrestamoDolar(float monto, DateTime vencimiento, PeriocidadDePagos periocidad) : base(monto, vencimiento)
        {
            this._periocidad = periocidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriocidadDePagos periocidad) : this(prestamo.Monto, prestamo.Vencimiento, periocidad)
        { }
        #endregion
    }
}
