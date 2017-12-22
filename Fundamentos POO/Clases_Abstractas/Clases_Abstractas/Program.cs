using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Clase abstracta = clase que no se puede instanciar.
//Sirve para definir super clases (clase al inicio de una jerarquia de clases).
//seria como una plantilla o estantar de clase. (lo unico que defino son las caracteristicas/Atributos que debe tener cada clase)

namespace Clases_Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sale error si instanciamos asi, porque no se puede instanciar directamente.
            //ClsAbsClientes cliente = new ClsAbsClientes();

            //Ahora si instanciamos a traves de la clase base
            ClsClientesBase cliente = new ClsClientesBase();

            cliente.Nombre = ("Juan");
            cliente.Id = 10;
            cliente.Clave = "PR21";
            cliente.TipoRegion = 5;

            Console.WriteLine(cliente.Id);
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine(cliente.Clave);
            Console.WriteLine(cliente.TipoRegion);

            Console.ReadKey();
        }
    }
}
