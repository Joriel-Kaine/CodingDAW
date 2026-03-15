using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class ListaProfesores
    {
        // Campos.
        private List<Profesor> _listaProfesores = new();



        // Métodos auxiliares.
        private int BuscarProfesorPorNombre(string nombre)
        {
            int posicion = -1;
            bool esEncontrado = false;
            nombre = nombre.ToLower();

            for (int i = 0; i < _listaProfesores.Count && !esEncontrado; i++)
            {
                Profesor profesor = _listaProfesores[i];

                if (profesor.Nombre.ToLower() == nombre)
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        public int BuscarProfesor(string dni)
        {
            int posicion = -1;
            bool esEncontrado = false;

            for (int i = 0; i < _listaProfesores.Count && !esEncontrado; i++)
            {
                Profesor profesor = _listaProfesores[i];

                if (profesor.DNI == dni)
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        public int CountProfesores()
        {
            return _listaProfesores.Count;
        }

        public Profesor DevolverProfesorPorPosicion(int posicion)
        {
            return _listaProfesores[posicion];
        }

        private void Swap(int i, int j)
        {
            Profesor aux = _listaProfesores[i];
            _listaProfesores[i] = _listaProfesores[j];
            _listaProfesores[j] = aux;
        }



        // Métodos principales.
        public void AddProfesor(Profesor profesor)
        {
            _listaProfesores.Add(profesor);
        }

        public string GenerarTextoDatosProfesor(string dni)
        {
            string datos = "Profesor no encontrado.";
            Profesor profesor;
            int posicion = BuscarProfesor(dni);

            if (posicion >= 0)
            {
                profesor = _listaProfesores[posicion];
                datos = profesor.GenerarTextoDatos();
            }

            return datos;
        }

        public void EliminarProfesorPorPosición(int posicion)
        {
            _listaProfesores.RemoveAt(posicion);
        }

        public bool EliminarProfesorPorNombre(string nombre)
        {
            bool esCorrecto = false;
            int posicion = BuscarProfesorPorNombre(nombre);

            if (posicion >= 0)
            {
                _listaProfesores.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public bool AddAsignaturaProfesor(string dni, string asignatura)
        {
            Profesor profesor;
            bool esEncontrado = false;
            int posicion = BuscarProfesor(dni);

            if (posicion >= 0)
            {
                profesor = _listaProfesores[posicion];
                profesor.AddAsignatura(asignatura);
                esEncontrado = true;
            }

            return esEncontrado;
        }

        public void OrdenarPorNombre()
        {
            for (int i = 0; i < _listaProfesores.Count - 1; i++)
            {
                for (int j = i + 1; j < _listaProfesores.Count; j++)
                {
                    if (_listaProfesores[i].Nombre.CompareTo(_listaProfesores[j].Nombre) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        public string GenerarTextoListaNombres()
        {
            string texto = "Lista de profesores:";
            int posicion = 1;

            foreach (Profesor profesor in _listaProfesores)
            {
                texto += $"\n{posicion} - {profesor.Nombre}";
                posicion++;
            }

            return texto;
        }

        public List<Profesor> ProfesoresConAsignaturas()
        {
            List<Profesor> listaProfesoresAsignaturas = new();

            foreach (Profesor profesor in _listaProfesores)
            {
                if (profesor.CountAsignaturas() > 0)
                {
                    listaProfesoresAsignaturas.Add(profesor);
                }
            }

            return listaProfesoresAsignaturas;
        }
    }
}
