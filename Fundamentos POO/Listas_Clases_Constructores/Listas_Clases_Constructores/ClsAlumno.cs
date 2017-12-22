using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Clases_Constructores
{
    public class ClsAlumno
    {
        /*
        //constructor por defectos alumno = establezco los valores para cuando inicializo el objeto
        //this - hace referencia a la clase "ClsAlumno"
        public ClsAlumno()
        {
            this.Curso = 1;
        }
        */

        /*
        //constructor parametizado
        public ClsAlumno(int pCurso)
        {
            this.Curso = pCurso;
        }
        */

        //sobrecargar constructor
        public ClsAlumno(int pCurso, char pLetra)
        {
            this.Curso = pCurso;
            this.Letra = pLetra;
        }

        //Propiedades
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Curso { get; set; }
        public char Letra { get; set; }
        //Agregamos fecha de alumno con la clase "DateTime"
        public DateTime Nacimiento { get; set; }

        //Hago una lista del objetos asignaturas
        //Propiedad de lista asignatura - Las listas se tienen que inicializar siempre con  " = new List<ClsAsignatura>()"
        public List<ClsAsignatura> Asignaturas { get; set; } = new List<ClsAsignatura>();

        //Metodo para calculasr la fecha
        public double CalcularPromedio()
        {
            double suma = 0.0;
            foreach (ClsAsignatura asignatura in Asignaturas)
            {
                suma += asignatura.Nota;
            }
            return suma / Asignaturas.Count;

        }
    }
}
