using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_Clases
{
    public class ClsEmpleados  //pongo el indentificador "public"
    {
        public string nombre;
        public double sueldoDiario;
        public int edad;

        public double CalculaSalario(int numDias)
        {
            return sueldoDiario * numDias;
        }

        //CONSTRUCTOR
        //Es un metodo que se ejecuta de manera automatica cuando se instancia un objeto de la clase 
        //Caracteristicas - es publico, no regresa ningun tipo y tiene el mismo nombre que la clase, se inicializan los valores de la clase

        public ClsEmpleados()
        {
            nombre = "";
            sueldoDiario = 0.0f;
            edad = 0;
        }
    }
}
