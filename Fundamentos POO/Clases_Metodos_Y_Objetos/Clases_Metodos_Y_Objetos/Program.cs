using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Metodos_Y_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEmpleados empleadoUno = new ClsEmpleados();
            empleadoUno.Nombre = "Cristian";
            empleadoUno.Apellido = "Silva";
            empleadoUno.Departamento = "Informatica";
            empleadoUno.Sexo = false;
            empleadoUno.SexoLegible = "Hombre";
            empleadoUno.Sueldo = 1000;

            ClsEmpleados empleadoDos = new ClsEmpleados();
            empleadoDos.Nombre = "Juan";
            empleadoDos.Apellido = "Perez";
            empleadoDos.Departamento = "Secretaria";
            empleadoDos.Sexo = false;
            empleadoDos.SexoLegible = "Mujer";
            empleadoDos.Sueldo = 1400;

            empleadoUno.SubirSueldo(10);
            Console.WriteLine(empleadoUno.ObtenerFicha());

            empleadoUno.BajarSueldo(10);
            Console.WriteLine(empleadoDos.ObtenerFicha());

            Console.ReadKey();
        }
    }
}
