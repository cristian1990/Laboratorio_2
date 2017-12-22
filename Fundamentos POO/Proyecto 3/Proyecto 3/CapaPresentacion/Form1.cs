using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Agregamos la capa negocio como una libreria
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        //Instanciamos la clase usuario vector para poder utilizarla
        VectorUsuario UsuarioObj = new VectorUsuario();        

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Convierto lo ingresado en el txt IdUsuario a entero y los demas
            UsuarioObj.GuardarDatosVector(Convert.ToInt32(TxtIdUsuario.Text), TxtLogin.Text, TxtClave.Text, TxtNombre.Text, DtpFecha.Value);

            //Mostramos los datos a travez del Data Grid Viever
            UsuarioObj.MostrarDatos(DgvListar);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
