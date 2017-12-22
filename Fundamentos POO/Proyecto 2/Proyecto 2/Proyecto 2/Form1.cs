using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class Form1 : Form
    {
        //Hacemos la llamada a los metodos, para eso construimos una instancia de la clase metodos.
        Metodos alumno = new Metodos();

        public Form1()
        {
            InitializeComponent();
        }
       
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            //Optenemos la opcion que se eligio y lo almacena en el atributo "tipo".
            string tipo = alumno.ObtenerOpcion(RbPrimario, rbSecundario, RbUniversitario);

            //Guardamos lo que se ingreso en el formulario
            alumno.GuardarDatos(TxtNombre.Text, tipo, DtpFecha.Value);

            //Mostramos los datos en el listbox
            alumno.Mostrar(LbDatos); //Ponemos el nombre de nuestra lista 
            TxtNombre.Clear();
            LbDatos.ClearSelected();
        }
    }
}
