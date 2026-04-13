using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class ListaProfesionales
    {
        private List<Profesional> _listaProfesionales = new();


        // Método auxiliar para buscar un profesional por su DNI.
        private int BuscarProfesional(string dni)
        {
            int posicion = -1;
            bool esEncontrado = false;
            dni = dni.ToUpper();

            for (int i = 0; i < _listaProfesionales.Count && !esEncontrado; i++)
            {
                Profesional profesional = _listaProfesionales[i];

                if (profesional.DNI == dni)
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        // Método donde se añade un profesional a la lista de profesionales.
        // Se usa como parámetro de entrada al profesional, con todos los datos ya introducidos.
        public void AddProfesional(Profesional profesional)
        {
            _listaProfesionales.Add(profesional);
        }

        // Método para eliminar un profesional por su DNI.
        public bool EliminarProfesionalPorDNI(string dni)
        {
            bool esCorrecto = false;
            int posicion = BuscarProfesional(dni);

            if (posicion >= 0)
            {
                _listaProfesionales.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public bool EliminarProfesionalPorPosicion(int posicion)
        {
            bool esCorrecto = false;

            if (posicion >= 0 && posicion < _listaProfesionales.Count)
            {
                _listaProfesionales.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public List<Profesional> DevolverListaProfesionales()
        {
            return _listaProfesionales;
        }
    }
}
