using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_4
{
    public partial class FormAlumno : Form
    {
        //Instanciamos la base de datos
        EscuelaDBEntities contexto; //Variable de la base de datos

        public FormAlumno()
        {
            InitializeComponent();
        }


        //Agregamos un metodo para limpiar los textbox cuando agreguemos un alumno
        private void LimpiarTextos()
        {
            TxtIdAlumno.Text = "";
            TxtNombre.Text = "";
            TxtApellidoPat.Text = "";
            TxtApellidoMat.Text = "";
            PxFotografia.ImageLocation = "";
        }

        //Agregamos otro metodo para que muestre los datos de la base de datos a nuestro DataGridViever
        private void LlenarGrid()
        {
            try
            {
                contexto = new EscuelaDBEntities();
                var datos = from alum in contexto.Alumnoes //La variable "datos" va a tener una consulta a la tabla alumnos...
                            select new
                            {
                                Nombre = alum.Nombre,
                                Paterno = alum.ApellidoPat, //con estos tipos que acabo de definir.
                                Materno = alum.ApellidoMat
                            };
                DgvDatos.DataSource = datos.ToList(); //Convertimos nuestra variable datos en una lista
                DgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Para que se ajuste a la cantidad de datos que tiene
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                contexto = new EscuelaDBEntities();

                //Creamos el constructor alumno con los datos.
                Alumno alumno = new Alumno()
                {
                    IdAlumno = int.Parse(TxtIdAlumno.Text),
                    Nombre = TxtNombre.Text,
                    ApellidoPat = TxtApellidoPat.Text,
                    ApellidoMat = TxtApellidoMat.Text,
                    Fotografia = TxtFotografia.Text,
                };

                //Agregamos el objeto a la base de datos
                //"Alumnoes" lo pone automaticamente al poner pluralizar
                contexto.Alumnoes.Add(alumno); //Agregue a la base de datos este alumno
                contexto.SaveChanges();
                MessageBox.Show("Alumno agregado correctamente");
                LimpiarTextos();
                LlenarGrid(); //Llamamos al metodo para que muestre los datos actualizados
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString()); //En caso de que haya error enviamos cual fue
            }
        }


        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog abrirArchivo = new OpenFileDialog();
                abrirArchivo.Title = "Abrir Imagen";
                abrirArchivo.Filter = "Archivos JPG (*.jpg, *jpeg) | *.jpg; *.jpeg";

                if(abrirArchivo.ShowDialog()==DialogResult.OK) //Si elegimos un archivo de imagen correcto
                {
                    string imagen = abrirArchivo.FileName;
                    TxtFotografia.Text = imagen;
                    PxFotografia.Image = Image.FromFile(imagen);
                }
                else
                {
                    MessageBox.Show("No se selecciono imagen");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: "+ ex.ToString());
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Buscamos a travez del id del alumno
                if(TxtIdAlumno.Text != string.Empty) //Si el txt de "IdAlumno" no esta vacio
                {
                    int clave = int.Parse(TxtIdAlumno.Text); //Comparamos el id con el Id de la basede datos que es tipo int
                    contexto = new EscuelaDBEntities();

                    Alumno alumBuscar = (from alum in contexto.Alumnoes
                                     where alum.IdAlumno == clave
                                     select alum).SingleOrDefault();
                    if(alumBuscar != null) //es decir, si la consulta de arriba genero un  resultado
                    {
                        //Si encontramos el alumno, llenamos los text box de nuestro formulario con los datos
                        TxtNombre.Text = alumBuscar.Nombre;
                        TxtApellidoPat.Text = alumBuscar.ApellidoPat;
                        TxtApellidoMat.Text = alumBuscar.ApellidoMat;
                        PxFotografia.Image = Image.FromFile(alumBuscar.Fotografia);
                    }
                    else
                    {
                        //Si no da resultado la busqueda, limpiamos los textBox
                        LimpiarTextos();
                        MessageBox.Show("No se encontro el registro");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtIdAlumno.Text != string.Empty) //Si el textBox del IdAlumno NO esta vacio
                {
                    int clave = int.Parse(TxtIdAlumno.Text);
                    contexto = new EscuelaDBEntities();
                    Alumno alumEliminar = (from alum in contexto.Alumnoes
                                           where alum.IdAlumno == clave
                                           select alum).SingleOrDefault();
                    if(alumEliminar != null )
                    {
                        //Se podria preguntar si de verdad se desea eliminar
                        contexto.Alumnoes.Remove(alumEliminar);
                        contexto.SaveChanges();
                        MessageBox.Show("Registro eliminado");                       
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtIdAlumno.Text != string.Empty)
                {
                    int clave = int.Parse(TxtIdAlumno.Text);
                    contexto = new EscuelaDBEntities();

                    Alumno alumActualizar = (from alum in contexto.Alumnoes
                                             where alum.IdAlumno == clave
                                             select alum).SingleOrDefault();
                    if(alumActualizar != null)
                    {
                        alumActualizar.Nombre = TxtNombre.Text;
                        alumActualizar.ApellidoPat = TxtApellidoPat.Text;
                        alumActualizar.ApellidoMat = TxtApellidoMat.Text;
                        alumActualizar.Fotografia = TxtFotografia.Text;

                        contexto.SaveChanges();
                        MessageBox.Show("Registro Actualizado");
                        LimpiarTextos();
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro registro");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.ToString());
            }
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}
