using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    public class Vector
    {
        private List<int> _componentes;

        public List<int> Componentes
        {
            get { return this._componentes; }
        }

        //Indexador
        public int this[int i]
        {
            get { return this._componentes[i]; }
            set { this._componentes[i] = value; }
        }

        public int Dimension
        {
            get { return this._componentes.Count; }
        }

        //Constructor
        public Vector(List<int> componentes)
        {
            this._componentes = componentes;
        }
    }
}
