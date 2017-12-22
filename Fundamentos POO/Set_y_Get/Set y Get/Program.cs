using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_y_Get
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------FORMA EXTENSA-------------
            //ENCAPSULAMIENTO - Ocultar los atributos/variables de una clase.
            //Instanciamos un objeto de la clase clsAutos
            ClsAutos autoUno = new ClsAutos();

            //seteamos el valor a autoUno
            autoUno.SetAuto ("Palio");

            //Obtenemos el valor de la raza
            Console.WriteLine(autoUno.GetAuto());
            */

            /*-----------FORMA ABREVIADA 1-------------
            ClsAutos autoUno = new ClsAutos();
            autoUno.Modelo = "Fiat";
            Console.WriteLine(autoUno.Modelo);

            ClsAutos autoDos = new ClsAutos();
            autoDos.Modelo = "Corsa";
            Console.WriteLine(autoDos.Modelo);
            */

            //-----------FORMA ABREVIADA 2-------------
            ClsAutos autoUno = new ClsAutos();

            autoUno.Modelo = "Fiesta";
            Console.WriteLine(autoUno.Modelo);

            Console.ReadKey();
        }
    }
}
