using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sale error si instanciamos asi, porque no se puede instanciar directamente.
            //ClsAbsClientes cliente = new ClsAbsClientes();

            //Ahora si instanciamos a traves de la clase clienteConContacto
            ClsClientesConContacto cliente = new ClsClientesConContacto();

            cliente.Nombre = ("Juan");
            cliente.Id = 10;
            cliente.Clave = "PR21";
            cliente.TipoRegion = 5;
            cliente.Telefono1 = "545484";
            cliente.Telefono2 = "485566";
            cliente.Email = "cristian@hotmail.com";
            cliente.Direccion.Calle = "Moreno 3280";
            cliente.Direccion.Provincia = "Buenos Aires";
            cliente.Direccion.CP = "A1232";

            //instancion la clase
            ClsImpresion Impresion = new ClsImpresion();
            //hago la llamada al metodo 
            Impresion.ImprimeClientes(cliente);

            Console.WriteLine(cliente.Telefono1);
            Console.WriteLine(cliente.Telefono2);
            Console.WriteLine(cliente.Email);
            Console.WriteLine(cliente.Direccion.Calle);
            Console.WriteLine(cliente.Direccion.Provincia);
            Console.WriteLine(cliente.Direccion.CP);

            Console.ReadKey();
        }
    }
}
