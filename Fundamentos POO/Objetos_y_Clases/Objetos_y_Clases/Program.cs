using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEmpleados Empleados; // Declaro la variable de la clase
            Empleados = new ClsEmpleados(); //Instanciamos objeto

            //Seteamos datos
            Empleados.edad = 25;
            Empleados.nombre = "Marcos Fernandez";
            Empleados.sueldoDiario = 12.5f;

            double total = Empleados.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado es: " + Empleados.nombre);
            Console.WriteLine("Es: "+ total.ToString("C"));

            Console.ReadKey();
        }
    }
}
