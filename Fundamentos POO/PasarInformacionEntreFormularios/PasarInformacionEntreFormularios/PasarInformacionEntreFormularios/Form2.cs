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
    public partial class Form2 : Form
    {
        //Creamos el delegado
        public delegate void pasar(string dato);  //pasar, nombre del delegado

        //Creamos el evento
        public event pasar Pasado; //Pasado, nombre del evento

        public Form2()
        {
            InitializeComponent();
        }

        private void BtnPasarDatos_Click(object sender, EventArgs e)
        {
            //Cuando demos click en "pasar datos" se envie el contenido de la caja de texto
            //al form 1 para que se muestre

            //al evento "Pasado", le enviamos el contenido del textbox
            Pasado(TxtDato.Text);

            this.Dispose(); //codigo para que el form se cierre
        }
    }
}
