using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class Profesor
    {
        // Campo.
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public int CodCursoTutor { get; set; }
        private List<string> _listaAsignaturas = new();

        // Constructor.
        public Profesor()
        {
            Nombre = "";
            DNI = "";
            CodCursoTutor = -1;
        }

        public Profesor(string nombre, string dni, int codCursoTutor)
        {
            Nombre = nombre;
            DNI = dni;
            CodCursoTutor = codCursoTutor;
        }

        // Método.

    }
}
