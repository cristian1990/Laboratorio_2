using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    public class MiColeccion<T, M>
    {
        public List<T> MiLista
        {
            get;
            set;
        }

        public List<M> MiListaM
        {
            get;
            set;
        }

        public MiColeccion()
        {
            MiLista = new List<T>();
            MiListaM = new List<M>();
        }

        public void Agregar(T valorT, M valorM)
        {
            MiLista.Add(valorT);
            MiListaM.Add(valorM);
        }
    }
}
