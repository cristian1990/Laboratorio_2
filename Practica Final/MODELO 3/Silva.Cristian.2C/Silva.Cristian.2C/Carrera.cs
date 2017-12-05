using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class Carrera
    {
        #region "Atributos"
        private List<Animal> _animales;
        private int _corredoresMax;
        #endregion

        #region "Metodos"
        public static string MostrarCarrera(Carrera carrera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CARRERA");

            for (int i = 0; i < carrera._animales.Count; i++)
            {
                if (carrera._animales[i] is Humano)
                    sb.AppendLine(((Humano)carrera._animales[i]).MostrarHumano());
                if (carrera._animales[i] is Perro)
                    sb.AppendLine(((Perro)carrera._animales[i]).MostrarPerro());
                if (carrera._animales[i] is Caballo)
                    sb.AppendLine(((Caballo)carrera._animales[i]).MostrarCaballo());
            }
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Carrera)
            {
                if ((Carrera)obj == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region "Constructores"
        public Carrera()
        {
            _animales = new List<Animal>();
        }

        public Carrera(int corredoresMax) : this()
        {
            this._corredoresMax = corredoresMax;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Carrera carrera, Animal animal)
        {
            bool retorno = false;

            foreach (Animal auxAnimal in carrera._animales)
            {
                if (auxAnimal.GetType() == animal.GetType() && auxAnimal == animal)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Carrera carrera, Animal animal)
        {
            return !(carrera == animal);
        }

        public static Carrera operator +(Carrera carrera, Animal animal)
        {
            if (carrera._animales.Count < carrera._corredoresMax)
            {
                foreach (Animal auxAnimal in carrera._animales)
                {
                    if (auxAnimal == animal)
                        return carrera;
                }
                carrera._animales.Add(animal);
            }
            return carrera;
        }
        #endregion
    }
}
