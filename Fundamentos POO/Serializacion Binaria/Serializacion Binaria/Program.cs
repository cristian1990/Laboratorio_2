using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para el formateador
using System.Runtime.Serialization.Formatters.Binary; //(Guarda el estado objeto en formato binario)
using System.IO; //Nos va a servir para que podamos hacer uso de un stream (secuencia de datos)

namespace Serializacion_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //SERIALIZACION = Toma el estado del objeto y lo guarda en algun medio de almacenamiento. (No son archivos).
            //DESERIALIZACION = Leer el estado del objeto.
            //Hay varios tipos  1)Binaria   2)Swap   3)HML 
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

                Auto miAuto = new Auto(modelo, costo);

                Console.WriteLine("Auto a serializar");
                miAuto.MuestraInformacion();

                //Empezamos la serializacion
                Console.WriteLine("------ Serializamos ------");

                //Seleccionamos el formateador (Adicionar los Using)
                //Hace una clase donde va a colocar, la informcion, el estado del objeto en un formato particular para que lo podamos serializar
                //BinaryFormatter = La clase que formatea el objeto y lo coloca en formato binario
                BinaryFormatter formateador = new BinaryFormatter();  //Instanciamos el formateador

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

            if(opcion == 2)
            {
                //Deserializamos el objeto
                Console.WriteLine("--- Deserializamos ---");

                //Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

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
