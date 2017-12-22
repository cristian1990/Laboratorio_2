using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_2
{
    //agrego public
    public class ClsImpresion
    {
        //agrego un metodo para imprimir clientes
        public void ImprimeClientes(ClsAbsClientes cliente)
        {
            Console.WriteLine(cliente.Id);
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine(cliente.Clave);
        }
    }
}
