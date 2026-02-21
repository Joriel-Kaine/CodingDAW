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

        public bool EliminarAlumnoPorNombre(string nombre)
        {
            int posicion;
            bool esCorrecto = false;

            posicion = BuscarAlumno(nombre);

            if (posicion >= 0)
            {
                _listaAlumnos.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public Alumno? MostrarMayorMediaAlumnos()
        {
            double mayorMedia = 0.0;
            Alumno? alumnoMediaMayor = null;

            foreach (Alumno alumno in _listaAlumnos)
            {
                double media = alumno.MediaNotas();

                if (mayorMedia < media)
                {
                    mayorMedia = media;
                    alumnoMediaMayor = alumno;
                }
            }

            return alumnoMediaMayor;
        }

        private int StringMasCorto(string alfa, string beta)
        {
            int menorLongitud;

            if (alfa.Length < beta.Length)
            {
                menorLongitud = alfa.Length;
            }
            else
            {
                menorLongitud = beta.Length;
            }

            return menorLongitud;
        }

        private bool EsMenorAlfabeto(string alfa, string beta)
        {
            bool esCorrecto = false, esDistintaLongitud = false;

            int menor = StringMasCorto(alfa, beta);

            for (int i = 0; i < menor; i++)
            {
                if (alfa[i] < beta[i])
                {
                    esCorrecto = true;
                    esDistintaLongitud = true;
                    break;
                }
                else if (alfa[i] > beta[i])
                {
                    esCorrecto = false;
                    esDistintaLongitud = true;
                    break;
                }
            }

            if (!esDistintaLongitud)
            {
                esCorrecto = alfa.Length < beta.Length;
            }

            return esCorrecto;
        }

        private void Swap(int i, int j)
        {
            Alumno aux;

            aux = _listaAlumnos[i];
            _listaAlumnos[i] = _listaAlumnos[j];
            _listaAlumnos[j] = aux;
        }

        public void OrdenarPorNombre()
        {
            int contador = CountAlumnos();

            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (!EsMenorAlfabeto(_listaAlumnos[i].Nombre, _listaAlumnos[j].Nombre))
                    {
                        Swap(i, j);
                    }

                    /*
                    if(_listaAlumnos[i].Nombre.CompareTo(_listaAlumnos[j].Nombre) > 0)
                    {
                        Swap(i, j);
                    }
                    */
                }
            }
        }

        public void OrdenarPorNotaMedia()
        {
            int contador = CountAlumnos();

            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (_listaAlumnos[i].MediaNotas() > _listaAlumnos[j].MediaNotas())
                    {
                        Swap(i, j);
                    }
                }
            }
        }
    }
}
