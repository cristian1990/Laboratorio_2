using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Clases_Constructores
{
    public class ClsAsignatura
    {
        //Version corta
        public string Nombre { get; set; }

        //Version larga
        //Escribimos get y set para poder manipular las notas
        private double _nota;
        //Validamos la nota
        public double Nota
        {
            get { return _nota;}
            set
            {
                if(value >= 0 && value <=10)
                {
                    _nota = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
