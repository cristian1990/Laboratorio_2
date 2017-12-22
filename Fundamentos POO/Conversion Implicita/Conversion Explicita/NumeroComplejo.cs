using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Explicita
{
    class NumeroComplejo
    {
        //a = parte real
        //b = parte imaginaria

        private int _numReal;
        private int _numDecimal;

        public int NumReal {
            get { return _numReal; }
            set {_numReal = value; }
        }
        public int NumeroDecimal {
            get {return _numDecimal; }
            set {_numDecimal = value; }
        }

        public NumeroComplejo(int pReal, int pDecimal)
        {
            this._numReal = pReal;
            this._numDecimal = pDecimal;
        }
        
        public override string ToString()
        {
            return string.Format("{0} + {1}",NumReal ,NumeroDecimal);
        }
        

        //creamos una conversion explicita a numeros reales
        //la clase "NumeroComplejo" es de donde sale la informacion
        //la clase "NumerosReales" de donde llega la informacion

        public static explicit operator NumerosReales(NumeroComplejo numComplejo) //Parametro del mismo tipo de la clase donde estoy
        {
            NumerosReales auxReal = new NumerosReales();
            auxReal.NumeroReal = numComplejo.NumReal;
            return auxReal;
        }

    }
}
