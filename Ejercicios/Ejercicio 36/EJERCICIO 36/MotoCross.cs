using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_36
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region "Atributos"
        private short _cilindrada;
        #endregion

        #region "Propiedades"
        public short Cilindrada
        {
            get { return this._cilindrada; }
            set { this._cilindrada = value; }
        }
        #endregion

        #region "Metodos"
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTOCROSS");
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendLine("CILINDRADA: " + this.Cilindrada);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is MotoCross);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region "Constructores"
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        { }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this._cilindrada = cilindrada;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(MotoCross moto1, MotoCross moto2)
        {
            bool retorno = false;
            if ((VehiculoDeCarrera)moto1 == (VehiculoDeCarrera)moto2 && moto1.Cilindrada == moto2.Cilindrada)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(MotoCross moto1, MotoCross moto2)
        {
            return !(moto1 == moto2);
        }
        #endregion
    }
}
