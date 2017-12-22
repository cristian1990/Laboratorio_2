using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, total;
            int cantidad;

            try  //"iNTENTA"(intenta hacer esa operacion)
            {
                Console.WriteLine("Ingrese Cantidad: ");
                cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese Precio: ");
                precio = Convert.ToInt32(Console.ReadLine());

                total = cantidad / precio;

                Console.WriteLine("La cantidad es: " + total);
            }
            //catch (Exception error) //"Si hay un error imprime el mensaje"
            //{
            //    Console.WriteLine("Ha ocurrido un error" + error.Message);
            //}
            finally
            {
                Console.WriteLine("\nExecution of the finally block after an unhandled\n");
            }
            Console.ReadKey();
        }
    }
}
