using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads__Hilos_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Instanciamos los objetos de hilo y colocamos los milisegundos y su progressbar.
            hilo1 = new Hilo(50,progressBar1);
            hilo2 = new Hilo(100,progressBar2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Iniciamos los Hilos (ProgressBar)
            hilo1.Inicia();
            hilo2.Inicia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //No hacemos nada
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cerramos los hilos
            hilo1.Termina();
            hilo2.Termina();
        }

        //Creamos variables de la clase hilo
        private Hilo hilo1;
        private Hilo hilo2;
    }
}
