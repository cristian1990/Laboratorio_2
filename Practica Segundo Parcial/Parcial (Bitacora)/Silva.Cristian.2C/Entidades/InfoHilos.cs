using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class InfoHilos
    {
        #region "Atributos"
        private IRespuesta<int> _callback;
        private Thread _hilo;
        private int _id;
        private static Random _randomizer;
        #endregion

        #region "Propiedades"
        #endregion

        #region "Metodos"
        // Ejecutar frenará el código durante un tiempo aleatorio de entre 1 y 5 segundos.Luego de
        // transcurrir este tiempo, utilizará el método RespuestaHilo de callback pasando como
        // parámetro el atributo id.
        private void Ejecutar()
        {
            int sleepSeg = (_randomizer.Next(1, 5) * 1000);
            Thread.Sleep(sleepSeg);
            this._callback.RespuestaHilos(_id);         
        }
        #endregion

        #region "Constructores"
        private InfoHilos()
        {
            _randomizer = new Random();
        }

        // El Thread hilo ejecutará el método Ejecutar
        public InfoHilos(int id, IRespuesta<int> callback) : this()
        {
            this._id = id;
            this._callback = callback;
            this._hilo = new Thread(Ejecutar);
            this._hilo.Start();
        }
        #endregion
    }
}
