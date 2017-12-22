using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Genericas_Clases
{
    class CPunto
    {
        private int _x;
        private int _y;

        public CPunto(int pX, int pY)
        {
            _x = pX;
            _y = pY;
        }

        public override string ToString()
        {
            return String.Format("x={0}, y={1}", _x, _y);
        }
    }
}
