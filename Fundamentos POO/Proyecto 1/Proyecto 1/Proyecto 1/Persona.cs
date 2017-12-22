using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar libreria - elementos de windows Form porque voy a utilizar sus elementos.
using System.Windows.Forms;

namespace Proyecto_1
{
    class Persona
    {
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private int _codigo;
        private DateTime _fechaNacimiento;


        public DateTime MyProperty
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string ApellidoMaterno
        {
            get { return _apellidoMaterno; }
            set {_apellidoMaterno = value; }
        }

        public string ApellidoPaterno
        {
            get { return _apellidoPaterno; }
            set {_apellidoPaterno = value; }
        }

        public Persona ()
        {

        }

        public void GuardarDatos(string nombre, string apeMaterno, string apePaterno, int cod, DateTime fechaNac)
        {
            this._nombre = nombre;
            this.ApellidoMaterno = apeMaterno;
            this._apellidoPaterno = apePaterno;
            this._codigo = cod;
            this._fechaNacimiento = fechaNac;
        }

        public void MostrarDatos(ListBox vista)
        {
            try
            {
                vista.Items.Add(_nombre);
                vista.Items.Add(_apellidoMaterno);
                vista.Items.Add(_apellidoPaterno);
                vista.Items.Add(_codigo);
                vista.Items.Add(_fechaNacimiento);
            }
            catch(Exception)
            {

            }
        }

        public string NombreCompleto()
        {
            return string.Format("Nombre: {0} {1} {2}", _nombre, ApellidoMaterno, ApellidoPaterno);
        }

        public string CalcularEdad()
        {
            //Guardamos la fecha actual de nuestra computadora en el atributo "fechaActual"
            DateTime fechaActual = DateTime.Now;

            //Guardamos el año actual de nuestra computadora en el atributo "añoActual"
            int añoActual = fechaActual.Year;

            //Calculamos los años de nacimiento
            int edad = añoActual - _fechaNacimiento.Year;

            return string.Format("Edad: {0} ",edad);
        }

    }
}
