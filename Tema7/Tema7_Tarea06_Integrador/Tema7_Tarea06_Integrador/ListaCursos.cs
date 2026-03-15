using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class ListaCursos
    {
        // Campos.
        private List<Curso> _listaCursos = new();

        // Métodos.
        public int BuscarCurso(int codCurso)
        {
            int posicion = -1;
            bool esEncontrado = false;

            for (int i = 0; i < _listaCursos.Count && !esEncontrado; i++)
            {
                Curso curso = _listaCursos[i];

                if (curso.CodCurso == codCurso)
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        public int CountCursos()
        {
            return _listaCursos.Count;
        }

        public Curso DevolverCursoPorPosicion(int posicion)
        {
            return _listaCursos[posicion];
        }

        public void AddCurso(Curso curso)
        {
            _listaCursos.Add(curso);
        }

        public bool EliminarCurso(int codCurso)
        {
            int posicion = BuscarCurso(codCurso);
            bool esCorrecto = false;

            if (posicion >= 0)
            {
                _listaCursos.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }
    }
}
