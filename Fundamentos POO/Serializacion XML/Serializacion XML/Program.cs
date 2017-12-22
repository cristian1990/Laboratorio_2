using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para el formateador
using System.Xml.Serialization; //(Guarda el estado objeto en formato Xml)
using System.IO; //Nos va a servir para que podamos hacer uso de un stream (secuencia de datos)

namespace Serializacion_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("\n1)Crear y Serializar Auto  \n2)Leer Auto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                //Creamos Objeto Auto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Que modelo es?");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                Auto miAuto = new Auto();

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                //Empezamos la serializacion
                Console.WriteLine("------ Serializamos ------");

                //Seleccionamos el formateador (Adicionar los Using)
                //Hace una clase donde va a colocar, la informcion, el estado del objeto en un formato particular para que lo podamos serializar
                //XmlSerializer = Debemos indicar el tipo del objeto que vamos a serializar - XmlSerializer(typeof(Objeto)) - De esta manera conoce los atributos dentro del objeto, si no no podria
                XmlSerializer formateador = new XmlSerializer(typeof(Auto));  //Instanciamos el formateador

                //Se crea el stream
                //Stream miStream = new FileStream("nombreArchivo", MododelArchivo, TipodeAcceso, ExclusividadArchivo)
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //Serializamos (se guarda en Bin/Debug)
                //Metodo Serialize = Metodo encargado de llevar a cabo la serialiazacion
                //Metodo Serialize(StreamUtilizado, ObjetoaSerializar) necesita estos 2 parametros             
                formateador.Serialize(miStream, miAuto);

                //Cerramos el Stream para descartar errores 
                miStream.Close();
            }

            if (opcion == 2)
            {
                //Deserializamos el objeto
                Console.WriteLine("--- Deserializamos ---");

                //Seleccionamos el formateador
                XmlSerializer formateador = new XmlSerializer(typeof(Auto));

                //Creamos Stream
                //FileStream("nombreArchivo", MododelArchivo ,TipodeAcceso, ExclusividadArchivo)
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserealizamos
                //Deserialize toma el archivo, lo saca de disco y nos lo devuelve como un object, por eso es necesario hacer un Typecast
                Auto miAuto = (Auto)formateador.Deserialize(miStream); //Stream con el que vamos a trabajar

                //Cerramos el Stream
                miStream.Close();

                //Usamos el objeto
                Console.WriteLine("El auto deserealizado es: ");
                miAuto.MuestraInformacion();
            }

            Console.ReadKey();
        }
    }
}
