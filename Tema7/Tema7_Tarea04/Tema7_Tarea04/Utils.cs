using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea04
{
    internal class Utils
    {
        /*
        private static void AddNota(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre();
            double nota = LeerNota("Introduce la nota");

            if (listaAlumnos.AddNotaAlumno(nombre, nota))
            {
                MessageBox.Show("Nota añadida.", "NOTA");
            }
            else
            {
                MessageBox.Show($"El alumno {nombre} no se ha encontrado.", "ERROR");
            }
        }

        private static void AddBirthday(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre();

            if (listaAlumnos.BirthdayAlumno(nombre))
            {
                MessageBox.Show($"¡Feliz cumpleaños, {nombre}!");
            }
            else
            {
                MessageBox.Show($"El alumno {nombre} no se ha encontrado.", "ERROR");
            }
        }

        public bool AddNotaAlumno(string nombre, double nota)
        {
            bool esCorrecto = false;
            int posicion;
            Alumno alumno;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                alumno.AddNota(nota);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public bool BirthdayAlumno(string nombre)
        {
            bool esCorrecto = false;
            int posicion;
            Alumno alumno;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                alumno = _listaAlumnos[posicion];
                alumno.Birthday();
                esCorrecto = true;
            }

            return esCorrecto;
        }
        */
    }
}
