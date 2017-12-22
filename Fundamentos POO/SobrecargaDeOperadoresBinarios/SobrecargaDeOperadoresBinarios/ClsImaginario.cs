using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadoresBinarios
{
    class ClsImaginario
    {
        //Atributos
        private double entero;
        private double imaginario;

        //Constructor
        //mismo nombre de la clase
        public ClsImaginario(double pEntero, double pImaginario)
        {
            Entero = pEntero;
            Imaginario = pImaginario;
        }

        //Propiedades
        //ctrl+R+E
        public double Entero { get => entero; set => entero = value; }
        public double Imaginario { get => imaginario; set => imaginario = value; }

        //Para mostrar el numero imaginario
        public override string ToString()
        {
            if(imaginario < 0)
            return string.Format("({0} {1}i)",entero, imaginario);
            else
                return string.Format("({0} + {1}i)", entero, imaginario);
        }

        //Sobrecargar de operadores binarios
        //a = i1 + i2
        public static ClsImaginario operator +(ClsImaginario i1, ClsImaginario i2)
        {
            double resEnt = 0;
            double resIma = 0;

            resEnt = i1.Entero + i2.Entero;
            resIma = i1.Imaginario + i2.Imaginario;

            ClsImaginario temporal = new ClsImaginario(resEnt, resIma);
            return temporal;
        }





    }
}
