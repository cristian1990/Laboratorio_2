using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MisPruebas 
{
    [TestClass]   
    public class PruebaDivision
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]  //Indicamos que lo que se espera que se devuelva sea una excepcion en este caso "DivideByZeroException".
        public void PruebaDividir()
        {
            //Arrange o Planeamiento
            const int numero1 = 8;
            const int numero2 = 0;

            //Act o Prueba
            var actual = Operaciones.Calculos.Dividir(numero1, numero2);

            //Asert => Excepcion
        }
    }
}
