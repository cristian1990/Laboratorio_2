using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//poner Using System.Collections

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            /*COLECCIONES adentro de System.Collection
             * Arraylist
             * BitArray
             * Hashtable (k,v)
             * Queue
             * Sortedlist (k,v)  k,[]
             * Stack
             */ 

            //Arraylist = Arreglo dinamico
            //Instanciamos la clase de arraylist, la cual llamamos "palabras"
            ArrayList palabras = new ArrayList();
            int i = 0;

            //Podemos adicionar con rango con AddRange, Se pasa una coleccion como parametro. Recorremos con ciclo for.
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\nUtilizando AddRange y For\n");
            palabras.AddRange(new string[] { "Hola", "como", "estan?" }); //Arreglo de string

            Console.WriteLine("La cantidad de elementos en el Arraylist es {0}", palabras.Count); //Count = es una propiedad que nos indica la cantidad de elementos que tenemos en nuestra coleccion

            for (i = 0; i < palabras.Count; i++)
            {
                    Console.Write(" {0}", palabras[i]);
            }


            //Otra forma de adicionar elementos, Utilizando Add y Foreach
            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("\nUtilizando Add y Foreach\n");
 
            palabras.Add("Bien y tu?\n");

            foreach (string pala in palabras)
                {
                    Console.Write(" {0}", pala);
                }


            //Utilizando Add y Foreach con numeros
            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine("Utilizando Add y Foreach con numeros\n");

            ArrayList numeros = new ArrayList();
            numeros.Add(10);
            numeros.Add(15);
            numeros.Add(8);
            numeros.Add(6);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            //Vemos si existe un elemento con Contains, False si no existe y True si existe 
            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine("Vemos si existe un elemento con Contains\n");

            bool existe = false;

            existe = numeros.Contains(7);
            Console.WriteLine(existe);

            existe = numeros.Contains(15);
            Console.WriteLine(existe);


            existe = numeros.Contains(5);
            if (existe == true)
            {
                Console.WriteLine("El numero existe");
            }
            else if(existe == false)
            {
                Console.WriteLine("El numero No existe");
            }


            //Insertar un numero en el indice elegido con Insert (indice,elemento)
            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine("Inserto el numero 68 en el indice 2 con Insert \n");
            numeros.Insert(2, 68);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            //Eliminamos un numero con remove
            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine("Eliminamos el numero 68 con remove\n");
            numeros.Remove(68);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            //Eliminamos un numero en el indice elegido con remove
            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine("Eliminamos el numero en el indice 2 con remove\n");
            numeros.RemoveAt(2);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
