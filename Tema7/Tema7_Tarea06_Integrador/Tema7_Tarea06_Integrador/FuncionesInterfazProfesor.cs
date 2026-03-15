using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public static class FuncionesInterfazProfesor
    {
        public static Profesor? AddProfesor(ListaProfesores listaProfesores)
        {
            Profesor? profesor = null;
            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del profesor a añadir:");
            string dni = FuncionesInterfaz.LeerDNI("Introduce el DNI:");
            int codCurso = FuncionesInterfaz.LeerCodigoCurso("Introduce el código del curso del que es tutor:");

            try
            {
                profesor = new(nombre, dni, codCurso);
                listaProfesores.AddProfesor(profesor);
                MessageBox.Show("Profesor añadido.", "");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Datos introducidos fuera de rango.", "");
            }

            return profesor;
        }

        public static void MostrarTodo(ListaProfesores listaProfesores)
        {
            int contador = listaProfesores.CountProfesores();

            for (int i = 0; i < contador; i++)
            {
                Profesor profesor = listaProfesores.DevolverProfesorPorPosicion(i);
                MessageBox.Show(profesor.GenerarTextoDatos(), $"Profesor {profesor.Nombre}");
            }
        }

        public static void MostrarDatosProfesor(ListaProfesores listaProfesores)
        {
            string dni = FuncionesInterfaz.LeerDNI("Introduce el DNI:");

            MessageBox.Show(listaProfesores.GenerarTextoDatosProfesor(dni), "");
        }

        public static void EliminarPorPosicion(ListaProfesores listaProfesores)
        {
            int posicion;

            posicion = FuncionesInterfaz.LeerEntero("Introduce la posición del profesor a eliminar:");

            if (posicion >= 0 && posicion < listaProfesores.CountProfesores())
            {
                listaProfesores.EliminarProfesorPorPosición(posicion);
                MessageBox.Show("Profesor eliminado correctamente.", "");
            }
            else
            {
                MessageBox.Show("Posición introducida fuera de rango.", "");
            }
        }

        public static void EliminarPorNombre(ListaProfesores listaProfesores)
        {
            bool esEncontrado = false;
            int contador = 0, total = listaProfesores.CountProfesores();

            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del profesor a eliminar:");

            for (int i = 0; i < total; i++)
            {
                if (nombre == listaProfesores.DevolverProfesorPorPosicion(i).Nombre)
                {
                    esEncontrado = true;
                    contador++;
                }
            }

            if (esEncontrado && contador > 1)
            {
                MessageBox.Show("Coincidencias en el nombre, se requiere DNI del profesor.", "");
                string dni = FuncionesInterfaz.LeerDNI("Introduce el DNI del profesor a eliminar.");

                if (listaProfesores.EliminarProfesorPorNombre(dni))
                {
                    MessageBox.Show("Profesor eliminado correctamente.", "");
                }
                else
                {
                    MessageBox.Show("El DNI del profesor no es correcto.", "");
                }
            }
            else
            {
                if (listaProfesores.EliminarProfesorPorNombre(nombre))
                {
                    MessageBox.Show("Profesor eliminado correctamente.", "");
                }
                else
                {
                    MessageBox.Show("No existe el profesor a eliminar.", "");
                }
            }
        }

        public static void AddAsignatura(ListaProfesores listaProfesores)
        {
            string dni = FuncionesInterfaz.LeerDNI("Introduce el DNI:");
            string asignatura = FuncionesInterfaz.LeerNombre("Introduce la asignatura del profesor:");
            bool esEncontrado = listaProfesores.AddAsignaturaProfesor(dni, asignatura);

            if (esEncontrado)
            {
                MessageBox.Show("Asignatura añadida.", "");
            }
            else
            {
                MessageBox.Show("El profesor no se ha encontrado.", "");
            }
        }

        public static void OrdenarPorOrdenAlfabetico(ListaProfesores listaProfesores)
        {
            listaProfesores.OrdenarPorNombre();

            MessageBox.Show("Lista de profesores ordenados alfabéticamente.", "");
        }
    }
}
