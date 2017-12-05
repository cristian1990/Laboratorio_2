using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silva.Cristian._2C
{
    public class DirectorTecnico : Persona
    {
        #region "Metodos"
        protected override string FichaTecnica()
        {
            return string.Format("{0} {1}",Nombre, Apellido);
        }

        public override string ToString()
        {
            return FichaTecnica();
        }
        #endregion

        #region "Constructores"
        public DirectorTecnico(string nombre, string apellido) : base(nombre, apellido)
        { }
        #endregion

    }
}
