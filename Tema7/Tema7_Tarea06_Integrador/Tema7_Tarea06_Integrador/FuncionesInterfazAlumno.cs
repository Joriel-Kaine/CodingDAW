using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class FuncionesInterfazAlumno
    {
        public static Alumno? AddAlumno(ListaAlumnos listaAlumnos)
        {
            Alumno? alumno = null;
            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del alumno a añadir:");

            try
            {
                alumno = new();
                alumno.Nombre = nombre;
                alumno.Edad = FuncionesInterfaz.LeerEdad("Introduce la edad:");
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
            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del alumno al que añadir la nota:");
            double nota = FuncionesInterfaz.LeerNota("Introduce la nota del alumno:");
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
            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del alumno que cumple años:");
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
            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del alumno a mostrar:");

            MessageBox.Show(listaAlumnos.MostrarDatosAlumno(nombre), "DATOS ALUMNO");
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

            posicion = FuncionesInterfaz.LeerEntero("Introduce la posición del alumno a eliminar:");

            if (posicion >= 0 && posicion < listaAlumnos.CountAlumnos())
            {
                listaAlumnos.EliminarAlumnoPorPosición(posicion);
                MessageBox.Show("Alumno eliminado correctamente.", "ALUMNO");
            }
            else
            {
                MessageBox.Show("Posición introducida fuera de rango.", "ERROR RANGO");
            }
        }

        public static void EliminarPorNombre(ListaAlumnos listaAlumnos)
        {
            bool esEncontrado = false;

            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del alumno a eliminar:");

            for (int i = 0; i < listaAlumnos.CountAlumnos(); i++)
            {
                if (nombre == listaAlumnos.DevolverAlumnoPorPosicion(i).Nombre)
                {
                    esEncontrado = true;
                    break;
                }
            }
            
            if (esEncontrado)
            {
                MessageBox.Show("Hay más de 1 coincidencia con ese nombre, se requiere el DNI.");
                string dni = FuncionesInterfaz.LeerDNI("Introduce el DNI del alumno a eliminar.");

                if (listaAlumnos.EliminarAlumnoPorDNI(dni))
                {
                    MessageBox.Show("Alumno eliminado correctamente.", "ALUMNO");
                }
                else
                {
                    MessageBox.Show("No existe el DNI del alumno a eliminar.");
                }
            }
            else
            {
                if (listaAlumnos.EliminarAlumnoPorNombre(nombre))
                {
                    MessageBox.Show("Alumno eliminado correctamente.", "ALUMNO");
                }
                else
                {
                    MessageBox.Show("No existe el alumno a eliminar.");
                }
            }
        }

        public static void MostrarAlumnoMayorNotaMedia(ListaAlumnos listaAlumnos)
        {
            Alumno? alumno = listaAlumnos.MostrarMayorMediaAlumnos();

            if (alumno != null)
            {
                MessageBox.Show($"{alumno.MostrarDatos()}\nNota media: {alumno.MediaNotas()}", "MAYOR MEDIA");
            }
            else
            {
                MessageBox.Show("El alumno no existe.");
            }
        }

        public static void OrdenarPorOrdenAlfabetico(ListaAlumnos listaAlumnos)
        {
            listaAlumnos.OrdenarPorNombre();

            MessageBox.Show("Lista de alumnos ordenados alfabéticamente.", "ALUMNO");
        }

        public static void OrdenarPorNotaMedia(ListaAlumnos listaAlumnos)
        {
            listaAlumnos.OrdenarPorNotaMedia();

            MessageBox.Show("Lista de alumnos ordenados por nota media.", "ALUMNO");
        }
    }
}
