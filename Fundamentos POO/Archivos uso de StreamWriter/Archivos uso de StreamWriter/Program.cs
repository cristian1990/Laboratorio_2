using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para trabajar conarchivos hay que añadir el "Using"
using System.IO;  //Permite crear algunas variables de tipo objeto que van a ser tratados como archivos

namespace Archivos_uso_de_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREAR ARCHIVO
            //Creamos un objeto de tipo StreamWriter = Para escribir texto.

            //Console.WriteLine("\n----------------------- Creamos el archivo ---------------------------\n");
            TextWriter archivo = new StreamWriter("dato.txt");  //Creamos un archivo de cualquier extencion.

            string mensaje = Console.ReadLine();  //Guardamos el texto ingresado por pantalla en la variable mensaje.

            archivo.WriteLine(mensaje);  //Guardamos el mensaje dentro del archivo.

            archivo.Close();  //Cerramos el archivo

            // Console.Clear();  //Limpiamos la pantalla

            Console.WriteLine("\nSe ha guardado el archivo");


            ////--------------------------------------------------------


            ////LEER ARCHIVO
            ////Creamos un objeto de tipo StreamReader = Para leer texto.

            Console.WriteLine("\n----------------------- Leemos el archivo ---------------------------\n");
            Console.ReadKey();

            TextReader leerArchivo = new StreamReader("dato.txt"); //Indico que archivo quiero que lea - Abrimos el archivo

            Console.WriteLine(leerArchivo.ReadToEnd());  //Imprime todas las lineas, incluyendo saltos de linea con el metodo "ReadToEnd".

            leerArchivo.Close();


            //--------------------------------------------------------


            //AGREGAR TEXTO A ARCHIVO
            //Creamos un objeto de tipo StreamWriter = Para creer texto.

            //File.AppendText = Añadir texto.
            StreamWriter dato = File.AppendText("dato.txt"); //Indico a que archivo quiero que se agregue texto.

            string mensaje2 = Console.ReadLine();

            dato.WriteLine(mensaje2);

            dato.Close();



            Console.ReadKey();
        }
    }
}
