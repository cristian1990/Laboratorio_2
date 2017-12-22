using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases_Alumnos
{
    public class ClsAlumnos
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sexo { get; set; }
        public int Curso { get; set; }
        public char Letra { get; set; }

        //Hacemos una lista de asignaturas
        public List<ClsAsignaturas> Asignaturas { get; set; } = new List<ClsAsignaturas>();

        //Metodo para calcular la edada del alumno
        public int EdadAlumno()
        {
            TimeSpan intervalo = DateTime.Now - this.FechaNacimiento;
            return (int)((double)intervalo.Days / 365.2425);
        }

        //Metodo para devolver el promedio de notas
        double sumaNotasAsignaturas = 0;

        foreach (ClsAsignaturas asignatura in this.Asignaturas)
        {
   
        }
        
    }
}
