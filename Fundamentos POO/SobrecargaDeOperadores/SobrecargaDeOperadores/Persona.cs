using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadores
{
    public class Persona
    {
        //Hago un constructor de una persona
        public Persona(double salario)
        {
            Salario = salario;
        }

        //Aplico sobrecarga de operadores
        //debe ser estatico. recibi 2 personas y tengo que hacer la suma de los salarios
        public static double operator + (Persona x, Persona y)
        {
            return x.Salario + y.Salario;
        }

        public double Salario { get; set; }
    }
}
