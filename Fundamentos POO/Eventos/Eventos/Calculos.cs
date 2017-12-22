using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Calculos
    {
        //delegado = Puntero a una funcion
        public delegate void Resultado();

        //Creamos un evento de resultado
        public event Resultado CalculoFinalizado;

        public void Calcular()
        {
            var evento = CalculoFinalizado;
            if (evento != null)
            {
                evento();
            }
        }
    }
}
