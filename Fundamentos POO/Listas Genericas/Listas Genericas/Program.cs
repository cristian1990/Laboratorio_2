using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos los objetos
            List<int> numeros = new List<int>();
            List<string> paises = new List<string>();

            //Insertamos elementos con ADD en la lista y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nInsertamos elementos con ADD en la lista y recorremos con Foreach y For\n");

            numeros.Add(20);
            numeros.Add(10);
            numeros.Add(40);
            numeros.Add(45);
            numeros.Add(70);
            numeros.Add(80);

            paises.Add("Rusia");
            paises.Add("España");
            paises.Add("Alemania");

            ////Recorremos con un ciclo FOR
            //for (int i = 0; i < numeros.Count ; i++)
            //{
            //    //No hay necesidada de type cast (50 = (int)20.10)
            //    int j = numeros[i];
            //    Console.WriteLine(j);
            //}

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(" ");

            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }


            //Vemos si contiene un elemento en la lista con CONTAINS y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nVemos si contiene un elemento en la lista con CONTAINS y recorremos con Foreach\n");

            bool existe;

            existe = numeros.Contains<int>(10);

            if (existe == false)
            {
                Console.WriteLine("El numero NO existe");
            }
            else
            {
                Console.WriteLine("El numero SI existe");
            }

            existe = paises.Contains<string>("España");

            if (existe == false)
            {
                Console.WriteLine("El numero NO existe");
            }
            else
            {
                Console.WriteLine("El numero SI existe");
            }


            //Vemos en que indice se encuentra el elemento indicado con INDEXOF
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nVemos en que indice se encuentra el numero 45 indicado con INDEXOF\n");

            int indice = numeros.IndexOf(45);

            Console.WriteLine("Se encuentra en el indice {0}", indice);


            //Insetamos un elemento en el indice especificado con INSERT y recorremos con Foreach - Insert(indice,elemento)
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nInsetamos un elemento en el indice especificado con INSERT \ny recorremos con Foreach\n");

            numeros.Insert(3,150);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            //Eliminamos un elemento en un indice especificado (3) con REMOVEAT y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nEliminamos un elemento en un indice especificado (3) con REMOVEAT\n");

            numeros.RemoveAt(3);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }



            //Eliminamos la primer ocurrencia de un elemento (40) en un REMOVE y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nEliminamos un elemento (40) en un REMOVE y recorremos con Foreach\n");

            numeros.Remove(40);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            //Usamos REVERSE para invertir el orden y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nUsamos REVERSE para invertir el orden y recorremos con Foreach\n");

            numeros.Reverse();

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            //Ordenamos la lista con SORT y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nOrdenamos la lista con SORT y recorremos con Foreach\n");

            numeros.Sort();

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            //Ordenamos la lista con SORT y recorremos con Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nOrdenamos la lista con SORT y recorremos con Foreach\n");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Creamos una lista para nuestra clase
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nCreamos una lista para nuestra clase\n");

            List<CPunto> listaPuntos = new List<CPunto>();  //Instanciamos la clase

            listaPuntos.Add(new CPunto(5, 3));
            listaPuntos.Add(new CPunto(7, 4));
            listaPuntos.Add(new CPunto(14, 8));
            listaPuntos.Add(new CPunto(12, 5));

            foreach (CPunto punto in listaPuntos)
            {
                Console.WriteLine(punto);
            }

            //No funciona porque SORT espera IComparable
            //listaPuntos.Sort();



            Console.ReadKey();
        }
    }
}
