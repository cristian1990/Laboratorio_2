using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormTest
{  
    public partial class Form1 : Form
    {
        Centralita centralita = new Centralita("Fede Center");
        Local llamadaLocal;
        Provincial llamadaProvincial;
        Local llamadaLocal2;
        Provincial llamadaProvincial2;

        public Form1()
        {
            InitializeComponent();

            // Mi central

            // Mis 4 llamadas
            llamadaLocal = new Local("Bernal", 30.5f, "Rosario", 2.65f);
            llamadaProvincial = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bernal");
            llamadaLocal2 = new Local("Lanús", 45, "San Rafael", 1.99f);
            llamadaProvincial2 = new Provincial(Provincial.EFranja.Franja_3, llamadaProvincial);           
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            // RtbListar.Text = centralita.ToString();
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            centralita.Llamadas.Add(llamadaLocal);
            RtbListar.Text = centralita.ToString();

            centralita.Llamadas.Add(llamadaProvincial);
            RtbListar.Text = centralita.ToString();

            centralita.Llamadas.Add(llamadaLocal2);
            RtbListar.Text = centralita.ToString();

            centralita.Llamadas.Add(llamadaProvincial2);
            RtbListar.Text = centralita.ToString();

            centralita.OrdenarLlamadas();
            RtbListar.Text = centralita.ToString();
        }
    }
}
