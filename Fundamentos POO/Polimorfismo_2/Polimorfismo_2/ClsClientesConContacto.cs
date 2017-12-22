using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    //Hereda todos los metodos y atributos de la clase "ClsClientesBase"
    class ClsClientesConContacto : ClsClientesBase
    {
        //Instanciamos los objeto en el constructor
        public ClsClientesConContacto()
        {
            _direccion = new ClsDirecciones();
        }


        //Hago una jerarquia con 3 clases, la clase abstracta, la cliente base(Implementa la clase abstracta), la cliente con contacto y la clase direccion.
        public ClsClientesConContacto(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen, string pNombreContacto, string pTel1, string pTel2, string pEmail, string pCalle, string pNumeroExterior, string pNumeroInterior, string pLocalidad, string pProvincia, string pCP)
        {
            //Accedo a los tributos de las clases y asigo
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegion = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTel1;
            Telefono2 = pTel2;
            Email = pEmail;
            //En caso de la direccion como es un objeto, porimero hago referencia al objeto.
            //primero instanciamos 
            _direccion = new ClsDirecciones();
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Localidad = pLocalidad;
            Direccion.Provincia = pProvincia;
            Direccion.CP = pCP;
        }


        //Metodos creados con prop + TAB + TAB
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        

        //encapsulo el atributo _direccion
        private ClsDirecciones _direccion;


        //O refactorizamos y encapsulamos los atributos con "ctrl + r + e"
        public ClsDirecciones Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }

    }
}
