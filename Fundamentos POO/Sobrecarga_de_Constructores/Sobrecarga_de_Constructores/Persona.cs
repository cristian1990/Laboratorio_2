using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_Constructores
{
    public class Persona
    {
        public int edad;
        public string nombre;

        //Constructor por defecto
        public Persona()
        {

        }

        //Constructor parametizado que toda la edad
        public Persona(int edad)
        {
            this.edad = edad;
        }

        //Constructor parametizado que toma la edad y el nombre
        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }
    }
}
