using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Universal",20); //20 = Grados con los que arranca

            //V1
            //Incrementamos 10 veces la temperatura de la candera de a 20 grados
            //for(int i = 0; i < 10; i++)
            //{
            //    miCaldera.Trabajar(20);
            //}


            //V2

            //try //Se pone el codigo de riesgo, que pueda tener una excepcion, el que puede tener el problema
            //{
            //    for(int i = 0; i < 10; i++)
            //    {
            //        miCaldera.Trabajar(20);
            //    }
            //}
            //catch(Exception e) //Siempre tiene que haber un catch cuando haya un try - sirve para capturar la excepcion // si en el throw pongo tipo "Exception" en el catch tiene que ser del mismo tipo
            //{   
            //    //Propiedades de Exception
            //    Console.WriteLine("\nSucedio la excepcion\n");
            //    Console.WriteLine("En este metodo: {0}\n", e.TargetSite);
            //    Console.WriteLine("Con este mensaje de error: {0}\n", e.Message);
            //    Console.WriteLine("Fuente: {0}\n", e.Source); //Cual es la "solucion" que genero el error

            //    Console.WriteLine("Clase donde ocurrio: {0}\n", e.TargetSite.DeclaringType);
            //    Console.WriteLine("Tipo de miembro: {0}\n", e.TargetSite.MemberType); //Que tipo de miembro genero un erro, en este caso un metodo

            //    Console.WriteLine("Stack: {0}\n", e.StackTrace); //recompila las invocaciones a metodos entre si que ocurrieron y la linea donde ocurrio el error
            //}



            //V3

            //try //Se pone el codigo de riesgo, que pueda tener una excepcion, el que puede tener el problema
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        miCaldera.Trabajar(20);
            //    }
            //}
            //catch (Exception e) //Siempre tiene que haber un catch cuando haya un try - sirve para capturar la excepcion // si en el throw pongo tipo "Exception" en el catch tiene que ser del mismo tipo
            //{
            //    Propiedades de Exception
            //    Console.WriteLine("\nSucedio la excepcion\n");
            //    Console.WriteLine("En este metodo: {0}\n", e.TargetSite);
            //    Console.WriteLine("Con este mensaje de error: {0}\n", e.Message);
            //    Console.WriteLine("Fuente: {0}\n", e.Source); //Cual es la "solucion" que genero el error

            //    Console.WriteLine("Clase donde ocurrio: {0}\n", e.TargetSite.DeclaringType);
            //    Console.WriteLine("Tipo de miembro: {0}\n", e.TargetSite.MemberType); //Que tipo de miembro genero un erro, en este caso un metodo

            //    Console.WriteLine("Stack: {0}\n", e.StackTrace); //recompila las invocaciones a metodos entre si que ocurrieron y la linea donde ocurrio el error
            //    Console.WriteLine("Help Link: {0}\n", e.HelpLink);
            //}



            //V4

            try //Se pone el codigo de riesgo, que pueda tener una excepcion, el que puede tener el problema
            {
                for (int i = 0; i < 10; i++)
                {
                    miCaldera.Trabajar(20);
                }
            }
            catch (Exception e) //Siempre tiene que haber un catch cuando haya un try - sirve para capturar la excepcion // si en el throw pongo tipo "Exception" en el catch tiene que ser del mismo tipo
            {
                //Propiedades de Exception
                Console.WriteLine("\nSucedio la excepcion\n");
                Console.WriteLine("En este metodo: {0}\n", e.TargetSite);
                Console.WriteLine("Con este mensaje de error: {0}\n", e.Message);
                Console.WriteLine("Fuente: {0}\n", e.Source); //Cual es la "solucion" que genero el error

                Console.WriteLine("Clase donde ocurrio: {0}\n", e.TargetSite.DeclaringType);
                Console.WriteLine("Tipo de miembro: {0}\n", e.TargetSite.MemberType); //Que tipo de miembro genero un erro, en este caso un metodo

                Console.WriteLine("Stack: {0}\n", e.StackTrace); //recompila las invocaciones a metodos entre si que ocurrieron y la linea donde ocurrio el error
                Console.WriteLine("Help Link: {0}\n", e.HelpLink);

                Console.WriteLine("\nImprimimos datos propios");

                //Verificamos que existan datos
                if(e.Data != null)
                {
                    //Imprimimos los datos extra propios
                    foreach (DictionaryEntry dato in e.Data)
                    {
                        Console.WriteLine("-> {0}  ->{1}", dato.Key, dato.Value);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
