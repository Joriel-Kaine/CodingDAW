using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class Curso
    {
        // Campos.
        public string Nombre { get; set; }
        private int _codCurso;

        // Propiedades.
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

        // Constructores.
        public Curso()
        {
            Nombre = "";
            _codCurso = -1;
        }

        public Curso(string nombre, int codCurso)
        {
            Nombre = nombre;
            CodCurso = codCurso;
        }

        // Métodos.
        public string MostrarDatos()
        {
            return $"Nombre del Curso: {Nombre}\n" +
                   $"Código del curso: {CodCurso}";
        }
    }
}
