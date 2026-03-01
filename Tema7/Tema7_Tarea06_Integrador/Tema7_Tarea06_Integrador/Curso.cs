using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class Curso
    {
        // Campo.
        public string Nombre { get; set; }
        private int _codCurso;

        // Propiedad.
        public int CodCurso
        {
            get { return _codCurso; }
            set
            {
                if (value < 100 || value > 200)
                {
                    throw new ArgumentOutOfRangeException("Valores fuera de rango.");
                }
                else
                {
                    _codCurso = value;
                }
            }
        }

        // Constructor.
        public Curso()
        {
            Nombre = "";
            CodCurso = -1;
        }

        public Curso(string nombre, int codCurso)
        {
            Nombre = nombre;
            CodCurso = codCurso;
        }

        // Método.
        public string MostrarDatos()
        {
            string texto;

            return texto = $"Nombre del Curso: {Nombre}\n" +
                           $"Código del curso: {CodCurso}";
        }
    }
}
