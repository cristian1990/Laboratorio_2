using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    class Boligrafo : IAcciones
    {
        private ConsoleColor _colorTinta;
        private float _tinta;

        public ConsoleColor Color
        {
            get {return this._colorTinta; }
            set {this._colorTinta = value; }
        }

        public float UnidadDeEscritura
        {
            get { return this._tinta; }
            set { this._tinta = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadDeEscritura = this.UnidadDeEscritura - 0.3f * texto.Length;
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadDeEscritura = this.UnidadDeEscritura + unidades;
            return true;
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadDeEscritura = unidades;
        }

        public override string ToString()
        {
            return String.Format("Boligrafo, Color: {0}, Cantidad Tinta: {1}", this.Color, this.UnidadDeEscritura);
        }
    }
}
