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
                texto += $"{posicion} - {alumno.Nombre}\n";
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
            int posicion;
            Alumno alumno;
            bool esEncontrado = false;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                alumno.AddNota(nota);
                esEncontrado = true;
            }

            return esEncontrado;
        }

        public bool BirthdayAlumno(string nombre)
        {
            int posicion;
            Alumno alumno;
            bool esEncontrado = false;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                alumno.Birthday();
                esEncontrado = true;
            }

            return esEncontrado;
        }

        public string MostrarDatosAlumno(string nombre)
        {
            int posicion;
            Alumno alumno;
            string datos = "Alumno no encontrado.";

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                datos = alumno.MostrarDatos();
            }

            return datos;
        }
        
        public bool EliminarAlumno(string nombre)
        {
            int posicion;
            bool esEncontrado = false;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                _listaAlumnos.RemoveAt(posicion);
                esEncontrado = true;
            }

            return esEncontrado;
        }
    }
}
