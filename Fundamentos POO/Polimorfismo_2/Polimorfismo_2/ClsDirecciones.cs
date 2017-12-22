using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    class ClsDirecciones
    {
        //CONSTRUCTOR, inicializa todas las cadenas al valor Empty del objeto string
        public ClsDirecciones()
        {
            Calle = string.Empty;
            NumeroExterior = string.Empty;
            NumeroInterior = string.Empty;
            Localidad = string.Empty;
            Provincia = string.Empty;
            CP = string.Empty;
        }

        //prop + TAB + TAB
        //Aparecen estos metodos de acceso.
        //De este modo la funcionalidad continua como en modo "public"
        public string Calle { get; set; }
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string CP { get; set; }
    }
}
