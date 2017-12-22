using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadores
{   //Ponemos public
    public class Program
    {   //Ponemos public
        public static void Main(string[] args)
        {
            //Instancio los objetos
            Persona juan = new Persona(10000.0);
            Persona ana = new Persona(5000.0);

            double salarioTotal = juan + ana;
            
            //Tambien podria hacer (salarioTotal = juan.Salario + ana.Salario;)

            Console.WriteLine("El salario es: " + salarioTotal);

            Console.ReadKey();

        }
    }
}
