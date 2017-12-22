using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_y_Get
{
    class ClsAutos
    {
        /* -------------FORMA EXTENSA----------------
        //String = objetos (color verde) // string = atributos comunes
        //Atrubutos son variables
        private string modelo;

        //Metodos son funciones, miebros de la clase.
        //Aplicamos Camel case
        public void SetAuto(string pModelo)
        {   //this - hacemos referencia a la clase donde estamos
            this.modelo = pModelo;
        }

        //Get - Regresa el valor que tiene auto
        public string GetAuto()
        {
            return this.modelo;
        }
        */

        /*------------FORMA ABREVIADA 1 -----------------
        //Utilizando propiedades y los metodos get y set de c#
        public string Modelo { get; set; }
        */

        //------------FORMA ABREVIADA 2 -----------------
        public string _modelo;

        public string Modelo
        {
            set { this._modelo = value; }
            get
            {
                switch (_modelo)
                {
                    case "Fiesta":
                        this._modelo += " Es marca Fort";
                        break;
                }

                return this._modelo; }
        }



    }
}
