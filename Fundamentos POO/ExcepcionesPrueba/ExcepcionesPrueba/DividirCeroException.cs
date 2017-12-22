using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPrueba
{
    public class DividirCeroException : Exception
    {
        public DividirCeroException() { }

        public DividirCeroException(string mensaje) : base(mensaje) { }
    }
}
