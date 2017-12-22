using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public class Metodos
    {
        #region Atributos
        private DateTime _fecha;
        private string _opcion;
        private string _texto;
        #endregion


        #region Propiedad
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Texto
        {
            get { return _texto; }
            set { _texto = value; }
        }

        public string Opcion
        {
            get { return _opcion; }
            set { _opcion = value; }
        }
        #endregion


        #region Constructor
        public Metodos()
        {
            _texto = "texto";
            _opcion = "";
            _fecha = DateTime.Now;

        }
        #endregion


        #region Metodos
        public void GuardarDatos(string texto, string opcion, DateTime fecha)
        {
            _texto = texto;
            _opcion = opcion;
            _fecha = fecha;
        }

        //para enlazar con en formulario agregamos la libreria "System.Windows.Forms" en el using arriba.
        public string ObtenerOpcion(RadioButton primario, RadioButton secundario, RadioButton universitario) //Va a recibir 3 radiobutton
        {
            if(primario.Checked) //Checket = esta elegido, si se eligio la opcion primaria.
            {
                return primario.Text; //Si se elegio pa opcion primario, se retorna su texto
            }
            if (secundario.Checked)
            {
                return secundario.Text;
            }
            else
            {
                return universitario.Text;
            }
        }


        public void Mostrar(ListBox lista) //Como lo quiero mostrar en un listBox necesito ese parametro
        {
            lista.Items.Add(_texto); //Adiciono en un item
            lista.Items.Add(_opcion); //Adiciono en un item
            lista.Items.Add(_fecha); //Adiciono en un item
        }
        #endregion



    }
}
