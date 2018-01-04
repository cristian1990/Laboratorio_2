using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio52
{
    public class Lapiz : IAcciones
    {
        private float _tamanioMina;

        public ConsoleColor Color
        {
            get {return ConsoleColor.Gray; }
            set => throw new NotImplementedException();
        }

        public float UnidadDeEscritura
        {
            get { return this._tamanioMina; }
            set { this._tamanioMina = value; }
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadDeEscritura = this.UnidadDeEscritura - 0.1f * texto.Length;
            return new EscrituraWrapper(texto, this.Color);
        }

        public Lapiz(int unidades)
        {
            this.UnidadDeEscritura = unidades;
        }

        public override string ToString()
        {
            return String.Format("Lapiz, Color: {0}, Tamaño Mina: {1}", this.Color, this.UnidadDeEscritura);
        }
    }
}
