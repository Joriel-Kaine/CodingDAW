using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea05
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

        // Método que muestra los datos de un alumno.
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

        // Método que devuelve una lista precargada de nombres de los alumnos.
        public string MostrarListaNombres()
        {
            string texto = "Lista de alumnos:";
            int posicion = 1;

            foreach (Alumno alumno in _listaAlumnos)
            {
                texto += $"\n{posicion} - {alumno.Nombre}";
                posicion++;
            }

            return texto;
        }

        // Método que cuenta los alumnos que hay y devuelve un entero con el total.
        public int CountAlumnos()
        {
            return _listaAlumnos.Count;
        }

        // Método que devuelve a un alumno mediante su posición.
        public Alumno DevolverAlumnoPorPosicion(int posicion)
        {
            return _listaAlumnos[posicion];
        }

        public void EliminarAlumnoPorPosición(int posicion)
        {
            _listaAlumnos.RemoveAt(posicion);
        }

        public void EliminarAlumnoPorNombre(string nombre)
        {
            _listaAlumnos.Remove(nombre);
        }
    }
}
