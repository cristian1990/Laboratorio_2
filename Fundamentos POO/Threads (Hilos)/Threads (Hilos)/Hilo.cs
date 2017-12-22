using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Incluimos este using
using System.Windows.Forms;
//Para manejar un hilo incluimos la biblioteca Threding
using System.Threading;

namespace Threads__Hilos_
{
    public class Hilo
    {
        //Creamos un constructor
        public Hilo(int milisegundos, ProgressBar progressBar)
        {         
            this._milisegundos = milisegundos;
            this._progresBar = progressBar;
            this._hilo = new Thread(new ThreadStart(ActualizarProgressBar));
        }

        //Creamos el metodo para iniciar
        public void Inicia()
        {
            _hilo.Start();
        }


        public void Termina()
        {
            _hilo.Abort();
        }

        //Cresmos el metodo de actualizacion
        private void ActualizarProgressBar()
        {
            while(true)  //While Infinito
            {
                MethodInvoker m = new MethodInvoker(() =>  //Expresion Lamda
                {
                    int valor = _progresBar.Value;  //Valor del progressbar
                    if(valor == 100)  //si el valor valo 100
                    {
                        valor = 0;  //lo pasamos a 0
                    }
                    else //en caso contrario
                    {
                        ++valor;  //el valor aumenta
                    }
                    _progresBar.Value = valor;  //el valor lo ponemos a la progressbar
                    Thread.Sleep(_milisegundos);  //dormimos el threads, los milisegundos que se ingresen 
                });


                //Invocamos a MethodInvoker
                if (_progresBar.InvokeRequired)
                {
                    _progresBar.Invoke(m);
                }
                else
                {
                    m.Invoke();
                }
            }
        }

        //Creamos una variable de ProgressBar
        private ProgressBar _progresBar;
        //Creamos un hilo
        private Thread _hilo;
        private int _milisegundos;
    }
}
