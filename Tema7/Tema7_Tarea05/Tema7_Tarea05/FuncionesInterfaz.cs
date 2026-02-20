using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                    MessageBox.Show("Introduce valores numéricos válidos.", "EROR FORMATO");
                }

            } while (!esCorrecto);

            return num;
        }

        public static int LeerEdad(string mensaje)
        {
            int edad;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);
                esCorrecto = int.TryParse(texto, out edad);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.", "ERROR FORMATO");
                }

            } while (!esCorrecto || (edad < 0 || edad > 100));

            return edad;
        }

        public static string LeerNombre(string mensaje)
        {
            int num;
            string nombre;
            bool esCorrecto;

            do
            {
                nombre = Interaction.InputBox(mensaje);
                esCorrecto = int.TryParse(nombre, out num);

                if (nombre.Trim() == "")
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "ERROR NOMBRE");
                }

                if (esCorrecto)
                {
                    MessageBox.Show("Introduce un nombre válido.", "ERROR FORMATO");
                }

            } while (nombre.Trim() == "" || esCorrecto);

            return nombre;
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
            string nombre = LeerNombre("Introduce el nombre del alumno a añadir:");

            try
            { 
                alumno = new();  
                alumno.Nombre = nombre;  
                alumno.Edad = LeerEdad("Introduce la edad:");  
                listaAlumnos.AddAlumno(alumno);
                MessageBox.Show("Alumno añadido.", "ALUMNO");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("La edad debe estar entre 0 y 100.", "ERROR EDAD");
            }

            return alumno;
        }

        public static void AddNota(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre("Introduce el nombre del alumno al que añadir la nota:");
            double nota = LeerNota("Introduce la nota del alumno:");
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
            string nombre = LeerNombre("Introduce el nombre del alumno que cumple años:");
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
            string nombre = LeerNombre("Introduce el nombre del alumno a mostrar:");

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
                Alumno alumno = listaAlumnos.DevolverAlumnoPorPosicion(i);
                MessageBox.Show(alumno.MostrarDatos(), $"DATOS ALUMNO {i + 1}");
            }
        }

        public static void EliminarPorPosicion(ListaAlumnos listaAlumnos)
        {
            int posicion;

            posicion = LeerEntero("Introduce la posición del alumno a eliminar:"); 

            if (posicion > 0 && posicion < listaAlumnos.CountAlumnos())
            {
                listaAlumnos.EliminarAlumnoPorPosición(posicion);
                MessageBox.Show($"Alumno eliminado correctamente.", "ALUMNO");
            }
            else
            {
                MessageBox.Show("Posición introducida fuera de rango.", "ERROR RANGO");
            }
        }

        public static void EliminarPorNombre(ListaAlumnos listaAlumnos)
        {
            string nombre = LeerNombre("Introduce el nombre del alumno a eliminar:");

            listaAlumnos.EliminarAlumnoPorNombre(nombre);
        }
    }
}
