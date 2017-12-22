using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//agregamos referencia
using System.Data.SqlClient;

namespace BaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                //Hacemos la conexion a la base de datos por medio del boton  //necesita el parametro de la cadena de conexion, de donde esta la base de datos  la que me quiero conectar
                SqlConnection conexion = new SqlConnection("Data Source=CRISTIAN\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
                conexion.Open();// abrimos la conexion a la base de datos
                MessageBox.Show("Se ha conectado");
            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }

        }
    }
}
