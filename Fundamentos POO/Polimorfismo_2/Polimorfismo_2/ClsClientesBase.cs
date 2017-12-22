using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    public class ClsClientesBase : ClsAbsClientes
    {
        //USAMOS 2 CONSTRUCTORES CON EL MISMO NOMBRE, NO HAY PROBLEMA MIENTRAS
        //QUE TENGAS DISTINTOS PARAMETROS, UNO ES POR DEFECTO Y EL OTRO PARAMETIZADO.

        //Agregamos constructores, que son publicos y no regresan ningun valor. Siempre tienen el mismo nombre de la clase.
        public ClsClientesBase()
        {
            Id = 0;
            Nombre = string.Empty; //empty = vacio
            Clave = string.Empty;
            RFC = string.Empty;
            TipoRegion = 0;
            NombreContacto = string.Empty;
        }


        //Hago otro constructor puedo poner muchos, lo importante es que se diferencien por sus parametros
        //Constructor parametizado para inicializar los atributos.
        public ClsClientesBase(int pId, string pNombre, string pClave, string pRFC, int pTipoRegion, string pNombreContacto)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegion = pTipoRegion;
            NombreContacto = pNombreContacto;
        }


        //Ponemos "override" para poder implementar los atributos. 
        //para indicar que estoy implementando los mismos atributos de la clase abstracta.
        public override int Id { get; set; }
        public override string Nombre { get; set; }
        public override string Clave { get; set; }
        public override string RFC { get; set; }
        public override int TipoRegion { get; set; }
        public override string NombreContacto { get; set; }
    }
}
