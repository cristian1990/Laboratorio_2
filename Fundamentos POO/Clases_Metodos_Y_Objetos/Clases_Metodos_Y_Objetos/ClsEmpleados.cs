using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Metodos_Y_Objetos
{
    public class ClsEmpleados
    {
        //Creamos las propiedades - prop + TAB + TAB
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Departamento { get; set; }   //get = leer    set = asignar
        public double Sueldo { get; set; }

        public bool Sexo { get; set; } //0 para mujer y 1 para hombre
        public string SexoLegible
        {
            get
            {
                if (this.Sexo == true) return "Mujer";
                else return "Hombre";
            }
            set
            {
                if (value.ToLower() == "Mujer") this.Sexo = true;
                else if (value.ToLower() == "Hombre") this.Sexo = false;
              //  else throw new ArgumentOutOfRangeException();
            }
        }

        

        //Creamos metodos NO estatico
        public string ObtenerFicha()
        {

            string ficha = "Nombre: " + this.Nombre + " " + this.Apellido + Environment.NewLine +
                "Departamento: " + this.Departamento + Environment.NewLine +
                "Sexo: " + this.SexoLegible + Environment.NewLine +
                "Sueldo: " + this.Sueldo + " EUROS" + Environment.NewLine;

            return ficha;
        }

        public void SubirSueldo(double porcentaje)
        {
            this.Sueldo += porcentaje * this.Sueldo / 100;
        }

        public void BajarSueldo(double porcentaje)
        {
            this.Sueldo -= porcentaje * this.Sueldo / 100;
        }
    }
}
