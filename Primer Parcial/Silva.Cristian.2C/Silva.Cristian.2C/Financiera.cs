using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Silva.Cristian._2C
{
    public class Financiera
    {
        #region "Atributos"
        private List<Prestamo> _listaPrestamo;
        private string _razonSocial;
        #endregion

        #region "Propiedades"
        public float InteresEnDolar
        {
            get { return CalcularInteresGanado(TipoDePrestamos.Dolar); }
        }

        public float InteresEnPesos
        {
            get { return CalcularInteresGanado(TipoDePrestamos.Pesos); }
        }

        public float InteresTotales
        {
            get { return CalcularInteresGanado(TipoDePrestamos.Todos); }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get { return _listaPrestamo; }
        }

        public string RazonSocial
        {
            get { return _razonSocial; }
        }
        #endregion

        #region "Metodos"
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("FINANCIERA: {0}\n", financiera.RazonSocial);
            sb.AppendLine("Intereses Ganados\n");
            sb.AppendFormat("TOTALES {0}\n", financiera.InteresTotales);
            sb.AppendFormat("PESOS {0}\n", financiera.InteresEnPesos);
            sb.AppendFormat("DOLARES {0}\n", financiera.InteresEnDolar);
            sb.AppendLine();
            foreach (Prestamo p in financiera.ListaDePrestamos)
            {
                sb.AppendLine(p.Mostrar());
            }
            return sb.ToString();
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera; //clave
        }

        public void OrdenarPrestamo()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        private float CalcularInteresGanado(TipoDePrestamos tipoPrestamo)
        {
            float
             interesesEnPesos = 0,
             interesesEnDolares = 0,
             interesGanado = 0;

            foreach (Prestamo prestamo in this.ListaDePrestamos)
            {
                if (prestamo is PrestamoDolar)
                    interesesEnDolares += ((PrestamoDolar)prestamo).Interes;
                if (prestamo is PrestamoPesos)
                    interesesEnPesos += ((PrestamoPesos)prestamo).Interes;
            }

            switch (tipoPrestamo)
            {
                case TipoDePrestamos.Dolar:
                    interesGanado = interesesEnDolares;
                    break;
                case TipoDePrestamos.Pesos:
                    interesGanado = interesesEnPesos;
                    break;
                default:
                    interesGanado = interesesEnPesos + interesesEnDolares;
                    break;
            }

            return interesGanado;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Financiera)
            {
                if ((Financiera)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        private Financiera()
        {
            _listaPrestamo = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this._razonSocial = razonSocial;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;

            foreach (Prestamo item in financiera._listaPrestamo)
            {
                if (item == prestamo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamo)
        {
            if (financiera != prestamo)
            {
                financiera._listaPrestamo.Add(prestamo);
            }
            return financiera;
        }
        #endregion
    }
}
