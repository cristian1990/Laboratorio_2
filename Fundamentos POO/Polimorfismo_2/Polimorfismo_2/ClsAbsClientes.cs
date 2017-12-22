using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    //clase abstracta = Una plantilla de clase.
    //Primer ponemos "public" + "abstract" 
    public abstract class ClsAbsClientes
    {
        //prop + TAB +TAB
        public abstract int Id { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string Clave { get; set; }
        public abstract string RFC { get; set; }
        public abstract int TipoRegion { get; set; }
        public abstract string NombreContacto { get; set; }
    }
}
