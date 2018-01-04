using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        #region "Atributos"
        protected string _razonSocial;
        private List<Llamada> _listaLlamadas;
        #endregion

        #region "Propiedades"
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return _listaLlamadas; }
        }
        #endregion

        #region "Metodos"
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada item in centralita._listaLlamadas)
            {
                if (item == llamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static Centralita operator +(Centralita centralita, Llamada nuevaLlamada)
        {
            if (centralita != nuevaLlamada)
            {
                centralita.AgregarLlamada(nuevaLlamada);
            }
            return centralita;
        }

        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }

        private float CalcularGanancia(Llamada.ETipoLlamada tipo)
        {
            float ganancia = 0;
            // Recorro la lista de llamadas.
            foreach (Llamada llamada in this._listaLlamadas)
            {
                // Según el tipo de llamada que quiero analizar, opero.
                switch (tipo)
                {
                    case Llamada.ETipoLlamada.Local:
                        // Si el TipoLlamada es Local y la clase es del tipo Local...
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).CostoLlamada;
                        }
                        break;

                    case Llamada.ETipoLlamada.Provincial:
                        // Si el TipoLlamada es Provincial y la clase es del tipo Provincial...
                        if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }
                        break;

                    case Llamada.ETipoLlamada.Todas:
                        // Si el TipoLlamada es Todas y verifico el tipo de la llamada para castear.
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }

                        break;
                }
            }

            return ganancia;
        }


        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CENTRAL  : " + this._razonSocial);
            sb.AppendLine("*******************************************");

            sb.AppendLine("GANANCIAS");
            sb.AppendLine("TOTALES        : " + this.GananciasPorTotal);
            sb.AppendLine("LOCALES        : " + this.GananciasPorLocal);
            sb.AppendLine("PROVINCIALES   : " + this.GananciasPorProvincial);

            sb.AppendLine("*******************************************");
            sb.AppendLine("DETALLE DE LLAMADAS");

            foreach (Llamada llamada in this._listaLlamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Centralita);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region "Constructores"
        public Centralita()
        {
            _listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion
    }
}
