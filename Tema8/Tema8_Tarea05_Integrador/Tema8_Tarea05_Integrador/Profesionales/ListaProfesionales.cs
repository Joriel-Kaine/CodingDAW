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
        public int BuscarProfesional(string dni)
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
        public bool AddProfesional(Profesional profesional)
        {
            bool esCorrecto = false;

            // Se asegura que no haya duplicados en el código único (DNI) antes de añadir.
            if (BuscarProfesional(profesional.DNI) < 0)
            {
                _listaProfesionales.Add(profesional);
                esCorrecto = true;
            }

            return esCorrecto; // Se devuelve un booleano para mostrar mensajes en el FORM.

        }

        // Método para eliminar un profesional por su DNI.
        public bool EliminarProfesionalPorDNI(string dni)
        {
            bool esCorrecto = false;
            int posicion = BuscarProfesional(dni); // Se busca la posición del Profesional.

            if (posicion >= 0) // Si es igual o mayor a 0, se elimina.
            {
                _listaProfesionales.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        // Método para eliminar un profesional por su posicion.
        public bool EliminarProfesionalPorPosicion(int posicion)
        {
            bool esCorrecto = false;

            // Se comprueba que la posición es válida.
            if (posicion >= 0 && posicion < _listaProfesionales.Count)
            {
                _listaProfesionales.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        // Método para devolver la lista de profesionales para usar en el FORM.
        public List<Profesional> DevolverListaProfesionales()
        {
            return _listaProfesionales;
        }

        // Método auxiliar para hacer una ordenación según convenga (Swap).
        private void Swap(int i, int j)
        {
            Profesional aux = _listaProfesionales[i];
            _listaProfesionales[i] = _listaProfesionales[j];
            _listaProfesionales[j] = aux;
        }

        private string ObtenerPuesto(Profesional profesional)
        {
            if (profesional is Designer designer)
            {
                return designer.Especialidad;
            }

            if (profesional is Desarrollador desarrollador)
            {
                return desarrollador.LenguajePrincipal;
            }

            if (profesional is Redactor redactor)
            {
                return redactor.TematicaPrincipal;
            }

            return "";
        }
        
        private int Comparar(int i, int j, string opcion)
        {
            switch (opcion)
            {
                case "Nombre":
                    return _listaProfesionales[i].Nombre.CompareTo(_listaProfesionales[j].Nombre);

                case "DNI":
                    return _listaProfesionales[i].DNI.CompareTo(_listaProfesionales[j].DNI);

                case "Puesto":
                    return ObtenerPuesto(_listaProfesionales[i])
                        .CompareTo(ObtenerPuesto(_listaProfesionales[j]));

                case "Salario hora":
                    return _listaProfesionales[i].CalcularPresupuesto()
                        .CompareTo(_listaProfesionales[j].CalcularPresupuesto());

                default:
                    return 0;
            }
        }

        public void OrdenarPor(string opcion)
        {
            for (int i = 0; i < _listaProfesionales.Count - 1; i++)
            {
                for (int j = i + 1; j < _listaProfesionales.Count; j++)
                {
                    if (Comparar(i, j, opcion) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }
    }
}
