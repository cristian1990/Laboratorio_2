using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsClientesVentas Cliente = new ClsClientesVentas();

            Cliente.IdCliente = 123;
            Cliente.Apellido = "silva";
            Cliente.Nombre = "cristian";
            Cliente.RFC = "HEHM";
            Cliente.Direccion = "Av. moreno 3280";
            Cliente.Provincia = "C.A.B.A";
            Cliente.EsCredito = true;

            Console.WriteLine("Id Cliente: " + Cliente.IdCliente);
            Console.WriteLine(Cliente.Apellido + " " + Cliente.Nombre);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Provincia);
            Console.WriteLine(Cliente.RFC);
            
            if(Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito");
            }
            else
            {
                Console.WriteLine("El cliente no tiene credito");
            }

            Console.ReadKey();
        }
    }
}
