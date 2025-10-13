using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIEstudiantes
{
    public class Estudiante
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }

        // Lista para almacenar las asignaturas con sus notas
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }
    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }
    }
    public static class DatosCompartidos
    {
        // Cambiamos el EstudianteActual por una lista de estudiantes
        public static List<Estudiante> ListaEstudiantes { get; set; } = new List<Estudiante>();
    }
}
