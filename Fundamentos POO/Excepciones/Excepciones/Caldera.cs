using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Caldera
    {
        private int _tempMax = 120;
        private int _tempActual = 0;
        private string _marca = "";
        private bool _funciona = true;

        public int TemperaturaActual
        {
            get { return _tempActual; }
            set { _tempActual = value; }
        }

        public string Marca
        {
            get {return _marca; }
            set {_marca = value; }
        }

        public bool Funciona
        {
            get {return _funciona; }
        }

        public Caldera (string marca, int temperaturaActual)
        {
            this._marca = marca;
            this._tempActual = temperaturaActual;
        }


        //V1
        //Hacemos tabajar la caldera sin usar Excepciones
        //public void Trabajar(int pAumento)
        //{
        //    if(_funciona == false)
        //    {
        //        Console.WriteLine("La caldera {0} no funciona", Marca);
        //    }
        //    else
        //    {
        //        _tempActual += pAumento;
        //        Console.WriteLine("La temperatura actual es de {0}", TemperaturaActual);

        //        if(_tempActual > _tempMax)
        //        {
        //            Console.WriteLine("{0} supero la temperatura, tiene {1}",Marca,TemperaturaActual);
        //            _tempActual = _tempMax;
        //            _funciona = false;
        //        }
        //    }
        //}



        ////V2
        ////Levantaremos una excepcion cuando sucede el problema
        //public void Trabajar(int pAumento)
        //{
        //    if (_funciona == false)
        //    {
        //        Console.WriteLine("La caldera {0} no funciona", _marca);
        //    }
        //    else
        //    {
        //        _tempActual += pAumento;
        //        Console.WriteLine("La temperatura actual es de {0}", _tempActual);

        //        if (_tempActual > _tempMax)
        //        {
        //            Console.WriteLine("{0} supero la temperatura, tiene {1}", Marca, _tempActual);
        //            _tempActual = _tempMax;
        //            _funciona = false;

        //            //Lanzamos la excepcion - throw = lanzar
        //            throw new Exception(string.Format("La caldera {0} se sobrecalienta", Marca));
        //        }
        //    }
        //}

        //V3
        //Informacion propia en una Excepcion
        //public void Trabajar(int pAumento)
        //{
        //    if (_funciona == false)
        //    {
        //        Console.WriteLine("La caldera {0} no funciona", _marca);
        //    }
        //    else
        //    {
        //        _tempActual += pAumento;
        //        Console.WriteLine("La temperatura actual es de {0}", _tempActual);

        //        if (_tempActual > _tempMax)
        //        {
        //            Console.WriteLine("{0} supero la temperatura, tiene {1}", Marca, _tempActual);
        //            _tempActual = _tempMax;
        //            _funciona = false;

        //            //Lanzamos la excepcion - throw = lanzar
        //            //Y tenemos una variable para la instancia (ex)
        //            Exception ex = new Exception(string.Format("La caldera {0} se sobrecalienta", Marca));
        //            ex.HelpLink = "http://google.com";  //HelpLink: no permite colocar un link donde esta la documentacion sobre el error

        //            //Luego hago el lanzamiento con throw
        //            throw ex;
        //        }
        //    }
        //}


        //V4
        //Informacion propia en una Excepcion
        public void Trabajar(int pAumento)
        {
            if (_funciona == false)
            {
                Console.WriteLine("La caldera {0} no funciona", _marca);
            }
            else
            {
                _tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", _tempActual);

                if (_tempActual > _tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", Marca, _tempActual);
                    _tempActual = _tempMax;
                    _funciona = false;

                    //Lanzamos la excepcion - throw = lanzar
                    //Y tenemos una variable para la instancia (ex)
                    Exception ex = new Exception(string.Format("La caldera {0} se sobrecalienta", Marca));
                    ex.HelpLink = "http://google.com";  //HelpLink: no permite colocar un link donde esta la documentacion sobre el error

                    //Adicionamos informacion propia a la excepcion
                    //Data = una coleccion en la que podemos colocar nuestros datos propios como un diccionario (nombreDelCampo,informacionDelCampo)
                    ex.Data.Add("Momento: ",string.Format("Ocurrio en {0}",DateTime.Now));
                    ex.Data.Add("Temperatura actual : ", string.Format("{0} grados", _tempActual));
                    ex.Data.Add("Incremento dado: ", string.Format("{0} grados", pAumento));

                    throw ex; //Luego lanzamos la excepcion
                }
            }
        }


    }
}
