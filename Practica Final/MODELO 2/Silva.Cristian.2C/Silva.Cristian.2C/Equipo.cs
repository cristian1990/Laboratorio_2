using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    class Equipo
    {
        #region "Enumeradores"
        public enum Deportes { Basquet, Futbol, Handball, Rugby };
        #endregion

        #region "Atributos"
        static Deportes _deporte;
        private DirectorTecnico _dt;
        static List<Jugador> _jugadores;
        static string _nombre;
        #endregion

        #region "Propiedades"
        public Deportes Deporte
        {
            get { return _deporte; }
            set { _deporte = value; }
        }
        #endregion

        #region "Metodos"
        public static implicit operator string(Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Huracan deSan Rafael Futbol**");
            sb.AppendLine("Nomina de jugadores");

            foreach (Jugador jugador in _jugadores)
            {
                sb.AppendLine(jugador.ToString());
            }

            sb.AppendFormat("Dirigido por: {0}", equipo._dt);

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Equipo)
            {
                if ((Equipo)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        static Equipo()
        {
            _deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt) : this()
        {
            _nombre = nombre;
            this._dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) : this(nombre,dt)
        {
            _deporte = deporte;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;

            foreach (Jugador auxJugador in _jugadores )
            {
                if (auxJugador == jugador)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }

        public static Equipo operator -(Equipo equipo, Jugador jugador)
        {
            foreach (Jugador auxJugador in _jugadores)
            {
                if (auxJugador == jugador)
                {
                    _jugadores.Remove(auxJugador);
                    break;
                }
            }

            return equipo;
        }


        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {

             foreach (Jugador auxJugador in _jugadores)
             {
                 if (auxJugador == jugador)
                        return equipo;
             }
            _jugadores.Add(jugador);
            return equipo;
        }
        #endregion

    }
}
