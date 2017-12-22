using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Las interfaces son conceptos abstractos por lo tanto no podemos tener objetos de ellas.
            //No se puede instanciar. 
            //Debo hacer una clase que implemente esa interfas.

            int opcion = 0;
            double valorA = 0;
            double valorB = 0;
            string valor = "";

            //Instanciamos un interfaz con la clase Suma
            IOperacion operacion = new Suma(); //Operacion es una variable polimorfica, va atrabajar de diferentes maneras

            while(opcion != 5)
            {
                Console.WriteLine("1-Suma, \n2-Resta, \n3-Multiplicacion, \n4-Division, \n5-Salir");
                Console.WriteLine("\nQue operacion deseas Realizar?\n");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el primer numero");
                valor = Console.ReadLine();
                valorA = Convert.ToDouble(valor);

                Console.WriteLine("Dame el segundo numero");
                valor = Console.ReadLine();
                valorB = Convert.ToDouble(valor);

                //Polimorfismo - Operacion actua como un objeto suma si la opcion es 1, si no como otro objeto
                if (opcion == 1)
                    operacion = new Suma();
                if (opcion == 2)
                    operacion = new Resta();
                if (opcion == 3)
                    operacion = new Multiplicacion();
                if (opcion == 4)
                    operacion = new Division();

                //Aqui nuestro programa trabaja en terminos del concepto, en lugar de en terminos de cosas concretas
                //como suma, resta, multiplicacion o division.

                operacion.Calcular(valorA, valorB);
                operacion.Mostrar();

            }

            Console.ReadKey();

        }
    }
}
