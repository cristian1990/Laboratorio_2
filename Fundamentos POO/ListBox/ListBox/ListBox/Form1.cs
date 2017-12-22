using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Es bueno realizar las inicializaciones aca, al cargar el formulario.
            //Adicionamos elementos

            LstFrutas.Items.Add("Banana");
            LstFrutas.Items.Add("Melon");
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            LstFrutas.Items.Add(TxtFruta.Text); //Agregamos el contenido que se encuentre en el textBox Frutas en la propiedad de text.

            TxtFruta.Text = ""; //Es recomendable limpiar el textBox
           // TxtFruta.Text = string.Empty; Otra forma de hacerlo
        }

        private void LstFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtenemos el elemento que se ha seleccionado visualmente 
            if(LstFrutas.SelectedIndex !=-1)
            lblFrutas.Text = (string)LstFrutas.Items[LstFrutas.SelectedIndex];  //SelectedIndex Nos guarda el indice del elemento seleccionado
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Si no hay elemento seleccionado el indice sera -1
            int indice = LstFrutas.SelectedIndex;

            if(indice != -1) //Si lo seleccionado no es -1 es que la seleccion es correcta.
            {
                LstFrutas.Items.RemoveAt(indice);
            }
        }
    }
}
