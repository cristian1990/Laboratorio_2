using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad_Y_Encapsulamiento
{
    class ClsEmpleados
    {
        //Encapsulamiento de datos guardamos las variables directas para que no puedan se accesadas desde cualquier lado.
        //cambiamos de public a private y guardamos como _nombre al ponerlos en privado ya no es una propiedad, ahora es un campo
        /*
        public string nombre;
        public double sueldoDiario;
        public int edad;
        */

        //click en _nombre y refactorizamos
        private string _nombre;
        private double _sueldoDiario;
        private int _edad;

        //Aparecen estos metodos de acceso.
        //De este modo la funcionalidad continua como en modo "public"
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public double SueldoDiario
        {
            get => _sueldoDiario;
            set => _sueldoDiario = value;
        }
        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }


        //Metodo para calcular el salario
        public double CalculaSalario(int numDias)
        {
            return _sueldoDiario * numDias;
        }


        //CONSTRUCTOR
        //Es un metodo que se ejecuta de manera automatica cuando se instancia un objeto de la clase 
        //Caracteristicas - es publico, no regresa ningun tipo y tiene el mismo nombre que la clase, se inicializan los valores de la clase

        public ClsEmpleados()
        {
            Nombre = "";
            _sueldoDiario = 0.0f;
            _edad = 0;
        }
    }
}
