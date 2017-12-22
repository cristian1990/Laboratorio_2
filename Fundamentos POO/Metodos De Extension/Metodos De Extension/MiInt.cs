using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Extension
{
    class MiInt : ISaludador
    {
        private int _numero;

        public MiInt(int numero)
        {
            this._numero = numero;
        }

        public override string ToString()
        {
            return string.Format("Tu Int Es {0}", _numero);
        }

        public void Saludar()
        {
            Console.WriteLine("Hola desde mi int {0}", _numero);
        }
    }
}
