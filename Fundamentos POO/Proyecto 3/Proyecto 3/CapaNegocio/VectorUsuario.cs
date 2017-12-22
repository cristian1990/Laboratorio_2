using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregar libreria para utilizar elementos de windows form
using System.Windows.Forms;

namespace CapaNegocio
{
    public class VectorUsuario
    {
        Usuario[] vectorUsuario = new Usuario[100];
        private int _dimension;

        public int Dimension
        {
            get { return _dimension; }
            set { _dimension = value; }
        }

        public VectorUsuario()
        {
            Dimension = 0;
        }


        public bool VectorNoLleno()
        {
            bool retorno = (Dimension < vectorUsuario.Length);
            return retorno;
        }

        public void GuardarDatosVector(int idUsuario, string login, string clave, string nombre, DateTime fExpiracion)
        {
            if (VectorNoLleno() == true)
            {
                vectorUsuario[Dimension] = new Usuario();
                vectorUsuario[Dimension].GuardarDatos(idUsuario, login, clave, nombre, fExpiracion);
                Dimension++;
            }
        }

        public void MostrarDatos(DataGridView dataGrid)
        {
            dataGrid.RowCount = Dimension;
            for(int i = 0; i < Dimension; i++)
            {
                dataGrid[0, i].Value = vectorUsuario[i].IdUsuario;
                dataGrid[1, i].Value = vectorUsuario[i].Login;
                dataGrid[2, i].Value = vectorUsuario[i].Clave;
                dataGrid[3, i].Value = vectorUsuario[i].Nombre;
                dataGrid[4, i].Value = vectorUsuario[i].FechaExpiracion;
            }
        }

    }
}
