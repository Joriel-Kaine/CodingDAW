using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea04
{
    public class ListaAlumnos
    {
        // Campo.
        private List<Alumno> _listaAlumnos = new();

        // Método.
        private int BuscarAlumno(string nombre)
        {
            int posicion = -1;
            bool esEncontrado = false;

            for (int i = 0; i < _listaAlumnos.Count && !esEncontrado; i++)
            {
                Alumno alumno;
                alumno = _listaAlumnos[i];

                if (alumno.Nombre.ToLower() == nombre.ToLower())
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        public Alumno? DevolverAlumno(string nombre)
        {
            int posicion;
            Alumno? alumno;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
            }
            else
            {
                alumno = null;
            }

            return alumno;
        }

        public void AddAlumno(Alumno alumno)
        {   
            _listaAlumnos.Add(alumno);
        }

        public Alumno? AddNotaAlumno(string nombre, double nota)
        {
            int posicion;
            Alumno? alumno;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                alumno.AddNota(nota);
            }
            else
            {
                alumno = null;
            }

            return alumno;
        }

        public Alumno? BirthdayAlumno(string nombre)
        {
            int posicion;
            Alumno? alumno;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                alumno.Birthday();
            }
            else
            {
                alumno = null;
            }

            return alumno;
        }

        public string MostrarDatosAlumno(string nombre)
        {
            string datos = "Alumno no encontrado.";
            int posicion;
            Alumno alumno;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                datos = alumno.MostrarDatos();
            }

            return datos;
        }
    }
}
