using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Genericas_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adicion con ADD
            //List <CPunto> listaPuntos = new List<CPunto>();

            //listaPuntos.Add(new CPunto(2,3));
            //listaPuntos.Add(new CPunto(5,23));
            //listaPuntos.Add(new CPunto(7,9));

            //foreach (CPunto punt in listaPuntos)
            //{
            //    Console.WriteLine(punt);
            //}


            //Lista de objetos de nuestra clase - Adicion explicita, sin ADD
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nALista de objetos de nuestra clase - Adicion explicita, sin ADD\n");

            List<CPunto> puntos = new List<CPunto>
            {
                new CPunto(2,3),
                new CPunto(5,23),
                new CPunto(7,9)

            };

            foreach (CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }

            //Adicionamos un punto con ADD
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nAdicionamos un punto con ADD\n");
            puntos.Add(new CPunto(45,90));

            foreach(CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }


            //Insertamos un punto en un indice especifico con INSERT y recorremos con Foreach - Insert(Indice,Elemento)
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nInsertamos un punto en un indice especifico con INSERT y recorremos con Foreach\n");

            puntos.Insert(2, new CPunto(100, 150));

            foreach (CPunto punto in puntos)
            {
                Console.WriteLine(punto);
            }


            //Copiamos de lista a Arreglo y recorremos con For
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nCopiamos de lista a Arreglo con TOARRAY y recorremos con For\n");

            CPunto[] arregloPuntos = puntos.ToArray();

            for(int i = 0; i<arregloPuntos.Length; i++)
            {
                Console.WriteLine(arregloPuntos[i]);
            }

            Console.ReadKey();
        }
    }
}
