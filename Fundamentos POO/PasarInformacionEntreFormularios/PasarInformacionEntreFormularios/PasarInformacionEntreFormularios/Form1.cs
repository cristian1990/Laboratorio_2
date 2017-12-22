using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasarInformacionEntreFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnElegirDato_Click(object sender, EventArgs e)
        {
            //Creamos un objeto del tipo form2
            Form2 formulario = new Form2();

            //Debemos asignar al evento "Pasado" el delegado que se va a encargar de llevar a cabo la accion.
            //Pasado solo tiene un delegado asignado
            formulario.Pasado += new Form2.pasar(Ejecutar); //pasamos el metodo
            formulario.ShowDialog();
        }

        //Creamos el metodo de nuestro delegado
        public void Ejecutar(string dato)
        {
            lblDato.Text = dato;
        }
    }
}
