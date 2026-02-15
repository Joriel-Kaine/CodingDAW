using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea03
{
    public class ListaAlumnos
    {
        private List<Alumno> _listaAlumnos;

        public ListaAlumnos()
        {
            _listaAlumnos = new();
        }

        public void AddAlumno(Alumno alumno)
        {
            _listaAlumnos.Add(alumno);
        }

        public string MostrarDatosListaAlumnos()
        {
            string texto = "\nLista de alumnos:\n";

            foreach (Alumno alumno in _listaAlumnos)
            {
                texto += alumno.MostrarDatos();
            }

            return texto;
        }

        public string MostrarNombresListaAlumnos()
        {
            string texto = "\nLista de alumnos:\n";
            int posicion = 1;

            foreach (Alumno alumno in _listaAlumnos)
            {
                texto += $"{posicion} - {alumno.Nombre}";
                posicion++;
            }

            return texto;
        }

        private int BuscarAlumno(string nombre)
        {
            int posicion = -1;
            bool esEncontrado = false;

            for (int i = 0; i < _listaAlumnos.Count && !esEncontrado; i++)
            {
                Alumno alumno = _listaAlumnos[i];

                if (alumno.Nombre == nombre)
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        public bool AddNotaAlumno(string nombre, double nota)
        {

        }

        public bool BirthdayAlumno(string nombre)
        {

        }

        public string MostrarDatosAlumno(string nombre)
        {

        }
        
        public bool EliminarAlumno(string nombre)
        {

        }
    }
}
