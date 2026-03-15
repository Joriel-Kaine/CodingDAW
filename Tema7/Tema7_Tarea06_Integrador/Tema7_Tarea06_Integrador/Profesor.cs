using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class Profesor
    {
        // Campos.
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public int CodCursoTutor { get; set; }
        private List<string> _listaAsignaturas = new();



        // Constructores.
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



        // Métodos.
        public void AddAsignatura(string asignatura)
        {       
            _listaAsignaturas.Add(asignatura);
        }

        private string GenerarTextoAsignaturas()
        {
            string texto;

            if (_listaAsignaturas.Count > 0)
            {
                texto = "Asignaturas:\n";

                for (int i = 0; i < _listaAsignaturas.Count; i++)
                {     
                    texto += $"{_listaAsignaturas[i]}\n";
                }
            }
            else
            {
                texto = "Profesor sin asignaturas.";
            }

            return texto;
        }

        public string GenerarTextoDatos()
        {
            return  $"Nombre: {Nombre}\n" +
                    $"DNI: {DNI}\n" +
                    $"Código de curso: {CodCursoTutor}\n" +
                    GenerarTextoAsignaturas();
        }

        public void EliminarAsignaturas()
        {
            _listaAsignaturas.Clear();
        }

        public int CountAsignaturas()
        {
            return _listaAsignaturas.Count;
        }
    }
}
