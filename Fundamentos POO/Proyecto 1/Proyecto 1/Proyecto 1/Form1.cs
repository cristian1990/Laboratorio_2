using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        //Instanciamos la clase "Persona" para poder utilizar su propiedades, metodos.
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Aca los datos llegan del formulario de diseño, ingresamos los nombre de los elementos de windosw form 
            //Guardo el texto que se ingresa en el formulario con ".text"
            //convertimos el codigo a int, con convert.ToInt32
            //el value, es porque sera la fecha ingresada que todavia no sabemos
            try
            {
                persona.GuardarDatos(txtNombre.Text, txtApeMaterno.Text, txtApePaterno.Text, Convert.ToInt32(txtCodigo.Text), dtpFechaNacimiento.Value);
            }
            catch(Exception)
            {
            }
            persona.MostrarDatos(lbDatos);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Guardamos los datos en el atributo "Datos"
            //string datos;
            //datos = String.Format("Nombre: {0} \nEdad: {1}", persona.NombreCompleto() ,persona.CalcularEdad());

            //Lo mostramos a travez de una ventana emergente
            //MessageBox.Show(datos);

            //Mostramos en el listBox
            lbDatos.Items.Clear(); //Limpio el listBox con los datos sin procesar
            lbDatos.Items.Add(persona.NombreCompleto()); //Muestro los datos
            lbDatos.Items.Add(persona.CalcularEdad()); //Muestro los datos
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
