using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad_Y_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEmpleados Empleados; // Declaro la variable de la clase
            Empleados = new ClsEmpleados(); //Instanciamos el objeto

            //Seteamos datos desde el objeto
            Empleados.Edad = 25;
            Empleados.Nombre = "Marcos Fernandez";
            Empleados.SueldoDiario = 12.0d;

            double total = Empleados.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado es: " + Empleados.Nombre);
            Console.WriteLine("Es: " + total.ToString("C"));

            Console.ReadKey();
        }
    }
}
