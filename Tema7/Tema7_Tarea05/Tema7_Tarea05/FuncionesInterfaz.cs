using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea05
{
    public static class FuncionesInterfaz
    {
        public static int LeerEntero(string mensaje)
        {
            int num;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);
                esCorrecto = int.TryParse(texto, out num);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.", "ERROR FORMATO");
                }

            } while (!esCorrecto || (num < 0 || num > 100));

            return num;
        }

        public static string LeerNombre()
        {
            return Interaction.InputBox("Introduce el nombre:");
        }

        public static double LeerNota(string mensaje)
        {
            double nota;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);
                esCorrecto = double.TryParse(texto, out nota);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.", "ERROR FORMATO");
                }

                if (nota < 0 || nota > 10)
                {
                    MessageBox.Show("La nota debe estar entre 0 y 10.", "ERROR RANGO");
                }

            } while (!esCorrecto || (nota < 0 || nota > 10));

            return nota;
        }

        public static Alumno? AddAlumno(ListaAlumnos listaAlumnos)
        {
            Alumno? alumno = null;
            string nombre = LeerNombre();

            try
            {
                if (nombre.Trim() != "")
                {
                    alumno = new();
                    alumno.Nombre = nombre;
                    alumno.Edad = LeerEntero("Introduce la edad:");
                    listaAlumnos.AddAlumno(alumno);
                    MessageBox.Show("Alumno añadido.", "ALUMNO");
                }
                else
                {
                    MessageBox.Show("No se puede añadir el alumno.", "ERROR ALUMNO");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("La edad debe estar entre 0 y 100.", "ERROR EDAD");
            }

            return alumno;
        }

        public static void AddNota(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre();
            double nota = LeerNota("Introduce la nota:");
            Alumno? alumno = listaAlumnos.AddNotaAlumno(nombre, nota);

            if (alumno != null)
            {
                MessageBox.Show("Nota añadida.", "NOTA");
            }
            else
            {
                MessageBox.Show($"El alumno {nombre} no se ha encontrado.", "ERROR ALUMNO");
            }
        }

        public static void AddBirthday(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre();
            Alumno? alumno = listaAlumnos.BirthdayAlumno(nombre);

            if (alumno != null)
            {
                MessageBox.Show($"¡Feliz cumpleaños, {nombre}!");
            }
            else
            {
                MessageBox.Show($"El alumno {nombre} no se ha encontrado.", "ERROR ALUMNO");
            }
        }

        public static void MostrarDatosAlumno(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre();

            MessageBox.Show(listaAlumnos.MostrarDatosAlumno(nombre), "DATOS ALUMNO");
        }

        public static void DatosEjemplo(ListaAlumnos listaAlumnos)
        {
            listaAlumnos.AddAlumno(new("Manu", 43));
            listaAlumnos.AddAlumno(new("Lito", 34));
            listaAlumnos.AddAlumno(new("Marina", 28));
            listaAlumnos.AddAlumno(new("Lidia", 38));
            listaAlumnos.AddAlumno(new("Carlos", 51));
            listaAlumnos.AddAlumno(new("Kathy", 25));
            listaAlumnos.AddAlumno(new("Lina", 45));
            listaAlumnos.AddAlumno(new("Pedro", 20));
        }

        public static void MostrarTodo(ListaAlumnos listaAlumnos)
        {
            int contador = listaAlumnos.CountAlumnos();

            for (int i = 0; i < contador; i++)
            {
                Alumno alumno = listaAlumnos.MostrarPosicion(i);
                MessageBox.Show(alumno.MostrarDatos(), $"DATOS ALUMNO {i + 1}");
            }
        }
    }
}
