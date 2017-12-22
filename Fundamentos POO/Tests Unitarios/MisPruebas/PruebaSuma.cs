using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MisPruebas
{
    [TestClass]  //Clases de pruebas
    public class PruebaSuma
    {
        [TestMethod]  //Metodos de prueba
        public void PruebaSumar()
        {
            //PARA LA REALIZACION DE LOS METODOS DE PRUEBA UTILIZAMOS REGLA DE LA TRIPLE A (Arrange, Act, Assert)

            // Arrange o Planeamiento.
            // Variables utilizadas para el testeo.
            const int numero1 = 3;
            const int numero2 = 5;
            const int esperado = 8;

            //Act o Prueba
            //llamamos al metodo a testear y guardamos el resultado.
            var actual = Operaciones.Calculos.Sumar (numero1, numero2); 

            //Asert o Afirmacion
            //Lanzamos el resultado de la prueba.
            Assert.AreEqual(esperado, actual);

        }
    }
}
