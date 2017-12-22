using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Metodo constructor, utilizado para inicializar variables, contienen todos los datos de utilizados para nuestro programa
//Es el primer metodo que se ejecuta, que se llama

namespace Metodo_Constructor_y_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana calculadora = new Ventana();
            calculadora.Mostrar();
       
            Console.ReadKey();
        }
    }

    class Ventana
    {
        //Atributos
        private int ancho, altura;
        private string color;

        //Constructor - siempre tiene el mismo nombre de la clase No tiene tipo pero si modificador de referencia
        public Ventana()
        {
            ancho = 15;
            altura = 20;
            color = "Rojo";
        }

        public void Mostrar()
        {
            Console.WriteLine("El ancho es: " + ancho);
            Console.WriteLine("La altura es: " + altura);
            Console.WriteLine("El color es: " + color);
        }

        //Metodo Destructor - se encarga de limpiar el recurso que no se va a utilizar mas (No es muy necesario hacerlo)
        ~Ventana()
        {
            System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos");
        }
    }
}
