using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuadar_Click(object sender, EventArgs e)
        {
            //declarar un cuadro para guardar
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de texto |*.txt"; // indicamos que se guardara en un archivo TXT
            guardar.Title = "Guardar RichTextBox";
            guardar.FileName = "Sin titulo 1";
            var resultado = guardar.ShowDialog();

            if(resultado==DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach(object line in rtbEscribir.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Documento de texto |*.txt"; // indicamos que se guardara en un archivo TXT
            abrir.Title = "Abrir RichTextBox";
            abrir.FileName = "Sin titulo 1";
            var resultado = abrir.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                rtbEscribir.Text = leer.ReadToEnd();
                leer.Close();
            }
        }
    }
}
