using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_36
{
    public class Competencia
    {
        #region "Enumeradores"
        public enum TipoCompetencia { F1, MotoCross}
        #endregion

        #region "Atributos"
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<VehiculoDeCarrera> _competidores;
        private TipoCompetencia _tipo;
        #endregion

        #region "Propiedades"
        public short CantidadCompetidores
        {
            get { return this._cantidadCompetidores; }
            set { this._cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this._cantidadVueltas; }
            set { this._cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get { return this._competidores[i]; }
        }
        #endregion

        #region "Metodos"
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("COMPETENCIA");
            sb.AppendLine("CANTIDAD DE COMPETIDORES: " + this.CantidadCompetidores);
            sb.AppendLine("CANTIDAD DE VUELTAS: " + this.CantidadVueltas);
            sb.AppendLine("TIPO: " + this.Tipo);

            for (int i = 0; i < this._competidores.Count; i++)
            {
                sb.Append(this._competidores[i].MostrarDatos());
            }

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Competencia);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region "Constructores"
        private Competencia()
        {
            this._competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo) : this()
        {
            this._cantidadVueltas = cantVueltas;
            this._cantidadCompetidores = cantCompetidores;
            this._tipo = tipo;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool retorno = false;

            foreach (VehiculoDeCarrera item in competencia._competidores)
            {
                if (item == vehiculo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }


        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool retorno = false;
            Random cantidadCombustible = new Random();
            switch (competencia.Tipo)
            {
                case TipoCompetencia.F1:
                    if (competencia._competidores.Count < competencia.CantidadCompetidores && competencia != vehiculo)
                    {
                        //if(a.GetType() == typeof(MotoCross))
                        if (vehiculo is AutoF1)
                        {
                            retorno = true;
                            vehiculo.EnCompetencia = true;
                            vehiculo.VueltasRestantes = competencia.CantidadVueltas;
                            vehiculo.CantidadCombustible = (short)cantidadCombustible.Next(15, 100);
                            competencia._competidores.Add(vehiculo);
                        }
                    }
                    break;

                case TipoCompetencia.MotoCross:
                    if (competencia._competidores.Count < competencia.CantidadCompetidores && competencia != vehiculo)
                    {
                        //if(a.GetType() == typeof(MotoCross))
                        if (vehiculo is MotoCross)
                        {
                            retorno = true;
                            vehiculo.EnCompetencia = true;
                            vehiculo.VueltasRestantes = competencia.CantidadVueltas;
                            vehiculo.CantidadCombustible = (short)cantidadCombustible.Next(15, 100);
                            competencia._competidores.Add(vehiculo);
                        }
                    }
                    break;
            }

            return retorno;
        }

        public static bool operator -(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            bool retorno = false;

            if (competencia._competidores.Contains(vehiculo))
            {
                retorno = true;
                vehiculo.EnCompetencia = false;
                vehiculo.VueltasRestantes = 0;
                vehiculo.CantidadCombustible = 0;
                competencia._competidores.Remove(vehiculo);
            }

            return retorno;
        }
        #endregion
    }
}
