using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EJERCICIO_36;

namespace FormTest
{
    public partial class Form1 : Form
    {
        Competencia competencia;
        MotoCross m1;
        AutoF1 a1;

        public Form1()
        {
            InitializeComponent();
            competencia = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            a1 = new AutoF1(1, "Mercedes", 5);
            AutoF1 a2 = new AutoF1(2, "Ferrari");
            AutoF1 a3 = new AutoF1(3, "RedBull");
            m1 = new MotoCross(4, "Honda", 110);
            MotoCross m2 = new MotoCross(10, "Zanella", 150);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(vehiculo.MostrarDatos());
            if (competencia + m1)
            {
                RtbListar.Text = competencia.MostrarDatos();
            }

            if (competencia + a1)
            {
                RtbListar.Text = competencia.MostrarDatos();
            }
        }
    }
}
