using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema8_Tarea05_Integrador.Profesionales;

namespace Tema8_Tarea05_Integrador.Proyectos
{
    public class ListaProyectos
    {
        private List<Proyecto> _listaProyectos = new();


        // Método auxiliar para buscar un proyecto por su código.
        public int BuscarProyecto(int codigo)
        {
            int posicion = -1;
            bool esEncontrado = false;

            for (int i = 0; i < _listaProyectos.Count && !esEncontrado; i++)
            {
                Proyecto proyecto = _listaProyectos[i];

                if (proyecto.Codigo == codigo)
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        // Método donde se añade un profesional a la lista de profesionales.
        // Se usa como parámetro de entrada al profesional, con todos los datos ya introducidos.
        public bool AddProyecto(Proyecto proyecto)
        {
            bool esCorrecto = false;

            // Se asegura que no haya duplicados en el código único (DNI) antes de añadir.
            if (BuscarProyecto(proyecto.Codigo) < 0)
            {
                _listaProyectos.Add(proyecto);
                esCorrecto = true;
            }

            return esCorrecto; // Se devuelve un booleano para mostrar mensajes en el FORM.
        }

        public List<Proyecto> DevolverListaProyectos()
        {
            return _listaProyectos;
        }
    }
}
