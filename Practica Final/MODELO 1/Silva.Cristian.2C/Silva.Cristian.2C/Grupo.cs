using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Grupo
    {
        #region "Enumeradores"
        public enum TipoManada { Mixta, Unica }
        #endregion

        #region "Atributos"
        static string _nombre;
        static TipoManada _tipo;
        static List<Mascota> _manada;
        #endregion

        #region "Propiedades"
        public TipoManada Tipo
        {
            set { _tipo = value;}
        }
        #endregion

        #region "Metodos"
        public static implicit operator string(Grupo grupo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**Rio Unica**");
            sb.AppendLine("Integrantes");
            foreach (Mascota item in _manada)
            {
                sb.AppendLine(item.ToString());
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
            if (obj is Grupo)//si mi obj es Gato
            {
                if ((Grupo)obj == this) //si obj es igual a mi instancia actual
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        static Grupo()
        {
            _tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            _manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            _nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            _nombre = nombre;
            _tipo = tipo;
        }

        #endregion

        #region "Sobrecargas"

        public static bool operator ==(Grupo grupo, Mascota mascota)
        {
            bool retorno = false;

            foreach (Mascota auxMascota in _manada)
            {
                if (auxMascota == mascota)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Grupo grupo, Mascota mascota)
        {
            return !(grupo == mascota);
        }

     // public static Mesa operator +(Mesa mesa, Comensal comensal)
        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {
             foreach (Mascota auxMascota in _manada)
             {
                 if (mascota == auxMascota)
                     return grupo;
             }
                _manada.Add(mascota);

            return grupo;
        }

   //   public static Changuito operator -(Changuito changuito, Producto producto)
        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            foreach (Mascota auxMascota in _manada)
            {
                if (auxMascota == mascota)
                {
                    _manada.Remove(mascota);
                    break;
                }
            }

            return grupo;
        }
        #endregion
    }
}
