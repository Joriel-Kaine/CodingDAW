using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Proyectos
{
    public class ListaProyectos
    {
        private List<Proyecto> _listaProyectos = new();


        // Métodos.
        public void AddProyecto(Proyecto proyecto)
        { 
            _listaProyectos.Add(proyecto);
        }

        public List<Proyecto> DevolverListaProyectos()
        {
            return _listaProyectos;
        }
    }
}
