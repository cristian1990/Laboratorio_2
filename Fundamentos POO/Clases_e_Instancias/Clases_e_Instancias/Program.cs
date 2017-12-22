using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clases e instancias
namespace Clases_e_Instancias
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana calculadora; //Creo una variable de la clase (El objeto claculadora hereda todos los atributos y metodos que tiene la clase ventana)
            calculadora = new Ventana(); //Instancio la clase

            //Solo puedor ver el metodo cerrar porque lo referencie como public
            calculadora.Cerrar();

            Console.ReadKey();
        }
    }

    class Ventana
    {
        //TIPOS DE MODIFICADORES DE REFERENCIA
        //public - (El atrubuto/metodo puede ser utilizado por cualquier clase)
        //private - (El atributo/metodo solo puede se utilizado solo por la clase donde fue creada)
        //static - (Indica que es un metodo de clase - Permite ejecutar un método sin tener que instanciar a una variable)
        //protected - (Solo accesible desde la clase o derivadas)

        //atributos = variables
        private int ancho = 15, altura = 20;
        private string color = "Rojo";

        //Metodos
        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerro!..");
        }

        private void Minimizar()
        {
            Console.WriteLine("La ventana se Minimizo");
        }

        static void Maximizar()
        {
            Console.WriteLine("La ventana se Agrando");
        }
    }
}
