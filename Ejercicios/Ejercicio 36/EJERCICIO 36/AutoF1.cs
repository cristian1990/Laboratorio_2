using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region "Enumeradores"
        #endregion

        #region "Atributos"
        private short _caballosDeFuerza;
        #endregion

        #region "Propiedades"
        public short CaballoDeFuerza
        {
            get { return this._caballosDeFuerza; }
            set { this._caballosDeFuerza = value; }
        }
        #endregion

        #region "Metodos"
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTO F1");
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendLine("CABALLOS DE FUERZA: " + this.CaballoDeFuerza);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is AutoF1);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region "Constructores"
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        { }

        public AutoF1(short numero, string escuderia, short caballosdefuerza): this(numero, escuderia) 
        {
            this._caballosDeFuerza = caballosdefuerza;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            bool retorno = false;
            if ((VehiculoDeCarrera)auto1 == (VehiculoDeCarrera)auto2 && auto1.CaballoDeFuerza == auto2.CaballoDeFuerza)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
        #endregion
    }
}
