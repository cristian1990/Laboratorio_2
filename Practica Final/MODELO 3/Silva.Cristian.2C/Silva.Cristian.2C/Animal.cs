using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public abstract class Animal
    {
        #region "Atributos"
        protected int _cantidadPatas;
        protected static Random _distanciaRecorrida;
        protected int _velocidadMaxima;
        #endregion

        #region "Propiedades"
        public int CantidadPatas
        {
            get { return _cantidadPatas; }
      
            set
            {
                if(_cantidadPatas > 0  && _cantidadPatas <= 4)
                {
                    _cantidadPatas = value;
                }
                else
                {
                    _cantidadPatas = 4;
                }
            }
        }

        private int DistanciaRecorrida
        {
            get { return Convert.ToInt32(_distanciaRecorrida.Next(1,10)); }
            //FALTA RETORNAR LA VELOCIDAD MAXIMA
        }

        public int VelocidadMaxima
        {
            get { return _velocidadMaxima; }
            set
            {
                if(_velocidadMaxima > 0 && _velocidadMaxima <= 60)
                {
                    _velocidadMaxima = value;
                }
                else
                {
                    _velocidadMaxima = 60;
                }
            }
        }
        #endregion

        #region "Metodos"
        public string MostrarDatos()
        {
            return string.Format("Cantidad Patas: {0} Distancia: {1} Velocidad: {2}", _cantidadPatas, _distanciaRecorrida, _velocidadMaxima);
        }
        #endregion

        #region "Constructores"
        static Animal()
        {
            _distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima)
        {
            this._cantidadPatas = cantidadPatas;
            this._velocidadMaxima = velocidadMaxima;
        }
        #endregion
    }
}
