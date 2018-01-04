using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivos
    {
        static string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\bitacora.txt";

        public static void GuardarEnTxt(string dato)
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
        }


        public static string LeerTxt()
        {
            StreamReader file = null;
            string data = "";
            try
            {
                if (File.Exists(archivo))
                {
                    file = new StreamReader(archivo);
                    data = file.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la ruta " + archivo, ex);
            }
            finally
            {
                file.Close();
            }
            return data;
        }
    }
}
