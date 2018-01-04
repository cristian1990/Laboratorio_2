using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace FormTest
{
    public partial class FrmPpal : Form
    {
        //Crearemos el atributo hilos
        LosHilos _hilos;

        public FrmPpal()
        {
            InitializeComponent();
            this._hilos = new LosHilos();
        }

        //Al presionar el botón Lanzar se deberá, mediante la sobrecarga del +, agregar un nuevo hilo
        //al atributo hilos.En caso de error, se mostrará mediante un MessageBox.
        private void BtnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this._hilos += 2;
            }
            catch (CantidadInvalidaException)
            {
                MessageBox.Show("La cantidad es menor a 1");
            }
        }

        //Al presionar el botón Bitacora se deberá mostrar por pantalla 
        //la bitacora guardada por hilos
        private void BtnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_hilos.Bitacora);
        }

        //MostrarMensajeFin mostrará por pantalla el mensaje recibido.
        //(enunciado sin parametros y sin void)
        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        //El evento AvisoFin de hilos deberá estar relacionado con el método MostrarMensajeFin 
        //del formulario.
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            _hilos.AvisoFin += MostrarMensajeFin;
        }
    }
}
