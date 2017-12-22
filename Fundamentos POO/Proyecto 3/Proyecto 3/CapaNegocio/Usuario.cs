using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Usuario
    {
        private int _idUsuario;
        private string _login;
        private string _clave;
        private string _nombre;
        private DateTime _fechaExpiracion;


        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime FechaExpiracion
        {
            get { return _fechaExpiracion; }
            set { _fechaExpiracion = value; }
        }

        public Usuario()
        {

        }

        public bool CalcularFechaExpirada()
        {
            bool verificacion = (DateTime.Today.Year > _fechaExpiracion.Year && DateTime.Today.Month > _fechaExpiracion.Month && DateTime.Today.Day > _fechaExpiracion.Day);
            return verificacion;
        }

        public void GuardarDatos(int idUsuario, string login, string clave, string nombre, DateTime fExpiracion)
        {
            //Utilizamos las propiedades para poder guargar los datos.
            IdUsuario = idUsuario;
            Login = login;
            Clave = clave;
            Nombre = nombre;
            FechaExpiracion = fExpiracion;            
        }


    }
}
