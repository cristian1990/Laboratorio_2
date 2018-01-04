using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {       
        #region "Evento Y Delegados"
        public delegate void delegaHilos(string mensaje);
        public event delegaHilos AvisoFin;
        #endregion

        #region "Atributos"
        private static int _id = 0;
        private List<InfoHilos> _misHilos;
        #endregion

        #region Propiedades

        public string Bitacora
        {
            //La propiedad Bitacora utilizará el set para generar un archivo en el escritorio de la máquina donde se ejecute llamado "bitacora.txt".
            get { return Archivos.LeerTxt(); }
            //El get retornará el contenido del mismo archivo.
            set { Archivos.GuardarEnTxt(value); }
        }
        #endregion

        #region "Metodos"
        //Método de clase AgregarHilo hará los siguientes pasos, en el siguiente orden:
        //i.Incrementará id.
        //ii.creará un nuevo InfoHilo y lo agregará a misHilos
        static LosHilos AgregarHilos(LosHilos hilos)
        {
            _id++;
            InfoHilos nuevoHilo = new InfoHilos(_id, hilos);
            hilos._misHilos.Add(nuevoHilo);
            return hilos;

        }
        #endregion

        #region "Constructores"
        public LosHilos()
        {
            _id = 0;
            _misHilos = new List<InfoHilos>();
        }

        //RespuestaHilo hará los siguientes pasos, en el siguiente orden:
        //i.Creará un mensaje con el siguiente formato: "Terminó el hilo {0}.".
        //ii.Guardará el mensaje en la bitácora.
        //iii.Ejecutará el evento AvisoFin.
        public void RespuestaHilos(int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Terminó el hilo {0}.", id);
            string mensaje = sb.ToString();
            this.Bitacora = mensaje;
            AvisoFin.Invoke(mensaje);
        }

        #endregion

        #region "Operadores"
        //El operador + lanzará la excepción CantidadInvalidaException en el caso de que la 
        //cantidad sea menor a 1.
        //Si cantidad es mayor a 0, deberá agregar tantos hilos cómo indique dicha cantidad.
        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
                if (cantidad > 0)
                {
                    for(int i = 0; i < cantidad; i++)
                    {
                        AgregarHilos(hilos);
                    }
                }
                else
                {
                    throw new CantidadInvalidaException();
                }
  
            return hilos;
        }
        #endregion
    }
}
