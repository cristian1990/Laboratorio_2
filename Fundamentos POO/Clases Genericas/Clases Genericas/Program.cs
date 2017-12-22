using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo instancias de distintos tipos para la clase CPunto

            // Para puntoI, T trabaja como INT 
            CTipos<int> puntoI = new CTipos<int>(3, 4);

            // Para PuntoD, T trabaja como DOUBLE
            CTipos<double> puntoD = new CTipos<double>(3.56, 4.88);

            // Para PuntoF, T trabaja como FLOAT
            CTipos<float> puntoF = new CTipos<float>(3.56f, 4.88f);

            // Para PuntoF, T trabaja como STRING
            CTipos<string> puntoS = new CTipos<string>("Hola","Cris");


            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nCreo instancias de distintos tipos para la clase CPunto\n");

            Console.WriteLine("\nEntero {0}", puntoI);
            Console.WriteLine("\nDouble {0}", puntoD);
            Console.WriteLine("\nFloat {0}", puntoF);
            Console.WriteLine("\nString {0}", puntoS);


            //Colocamos el valor por default con la funcion creada Reset
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\n\nColocamos el valor por default con el metodo creada Reset\n");

            puntoI.Reset();
            puntoF.Reset();
            puntoD.Reset();
            puntoS.Reset();

            Console.WriteLine("\nEntero {0}", puntoI);
            Console.WriteLine("\nDouble {0}", puntoD);
            Console.WriteLine("\nFloat {0}", puntoF);
            Console.WriteLine("\nString {0}", puntoS);


            //Verificamos con que tipo estamos trabajando, con la funcion creada EncuentraTipo
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\n\nVerificamos con que tipo estamos trabajando, con el metodo EncuentraTipo\n");

            puntoI.EncuentraTipo();
            puntoF.EncuentraTipo();
            puntoD.EncuentraTipo();
            puntoS.EncuentraTipo();


            Console.ReadKey();
        }
    }
}
