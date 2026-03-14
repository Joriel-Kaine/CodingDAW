using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public static class FuncionesInterfazCurso
    {
        public static void AddCurso(ListaCursos listaCursos)
        {
            string nombre = FuncionesInterfaz.LeerNombre("Introduce el nombre del curso a añadir:");
            int codCurso = FuncionesInterfaz.LeerCodigoCurso("Introduce el código del curso al que pertenece:");

            try
            {
                Curso curso = new(nombre, codCurso);
                listaCursos.AddCurso(curso);
                MessageBox.Show("Curso añadido.", "");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Datos introducidos fuera de rango.", "");
            }
        }

        public static void EliminarCurso(ListaCursos listaCursos)
        {
            int contador = listaCursos.CountCursos(),
                codCurso = FuncionesInterfaz.LeerCodigoCurso("Introduce el código del curso a eliminar:"),
                posicion = listaCursos.BuscarCurso(codCurso);

            if (posicion >= 0)
            {
                Curso curso = listaCursos.DevolverCursoPorPosicion(posicion);
                listaCursos.EliminarCurso(codCurso);

                MessageBox.Show($"El curso de {curso.Nombre} se ha eliminado correctamente.", "");
            }
            else
            {
                MessageBox.Show($"El código {codCurso} no pertenece a ningún curso.", "");
            }
        }

        public static void MostrarTodo(ListaCursos listaCursos)
        {
            int contador = listaCursos.CountCursos();

            for (int i = 0; i < contador; i++)
            {
                Curso curso = listaCursos.DevolverCursoPorPosicion(i);
                MessageBox.Show(curso.MostrarDatos(), $"Curso {curso.Nombre}");
            }
        }

        public static void MostrarAlumnosCurso(ListaCursos listaCursos)
        {

        }
    }
}
