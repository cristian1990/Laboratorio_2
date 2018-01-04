using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesHechas
{
    public static class GuardaString
    {

        static string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivo.txt";

        public static bool Guardar(this string texto, string dato)
        {
            StreamWriter file = null;
            try
            {
                if (File.Exists(archivo))
                    file = new StreamWriter(archivo, true);
                else
                    file = new StreamWriter(archivo);

                file.WriteLine(dato);
                
            }
            catch (IOException ex)
            {
                throw new IOException("Error al guardar en la ruta " + archivo, ex);
            }
            finally
            {
                file.Close();
            }
            return true;
        }
    }
}
