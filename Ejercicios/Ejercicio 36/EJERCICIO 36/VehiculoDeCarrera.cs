using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_36
{
    public class VehiculoDeCarrera
    {
        #region "Atributos"
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;
        #endregion

        #region "Propiedades"
        public short CantidadCombustible
        {
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this._escuderia; }
            set { this._escuderia = value; }
        }

        public short Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public short VueltasRestantes
        {
            get { return this._vueltasRestantes; }
            set { this._vueltasRestantes = value; }
        }
        #endregion

        #region "Metodos"
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("VEHICULOS DE CARRERA");
            sb.AppendLine("CANTIDAD COMBUSTIBLE: " + CantidadCombustible);
            sb.AppendLine("¿EN COMPETENCIA?: " + EnCompetencia);
            sb.AppendLine("ESCUDERIA: " + Escuderia);
            sb.AppendLine("NUMERO: " + Numero);
            sb.AppendLine("VUELTAS RESTANTES: " + VueltasRestantes);

            return sb.ToString();
        }
        #endregion

        #region "Constructores"
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
        }
        #endregion

        public static bool operator !=(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

        public static bool operator ==(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            bool retorno = false;
            if (vehiculo1.Numero == vehiculo2.Numero && vehiculo1.Escuderia == vehiculo2.Escuderia)
            {
                retorno = true;
            }

            return retorno;
        }

        public override bool Equals(object obj)
        {
            return (obj is VehiculoDeCarrera);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
