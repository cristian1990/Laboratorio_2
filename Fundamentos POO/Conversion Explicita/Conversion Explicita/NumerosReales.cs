using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Explicita
{
    class NumerosReales
    {
        private double _numeroReal;

        public double NumeroReal
        {
            get { return _numeroReal; }
            set {_numeroReal = value; }
        }

        public NumerosReales()
        {

        }

        public NumerosReales(double num)
        {
            this._numeroReal = num;
        }

        public override string ToString()
        {
            return string.Format("Numero Real = {0}", NumeroReal);
        }


    }
}
