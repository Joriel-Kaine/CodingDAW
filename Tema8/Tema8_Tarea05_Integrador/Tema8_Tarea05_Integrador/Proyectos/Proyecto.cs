using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema8_Tarea05_Integrador.Profesionales;

namespace Tema8_Tarea05_Integrador.Proyectos
{
    public class Proyecto
    {
        // Campos privados.
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Duracion { get; set; }

        private List<Profesional> _listaProfesionales = new();


        // Constructor con parámetros de entrada.
        public Proyecto(string nombre, int codigo, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Duracion = duracion;
        }


        // Método.
    }
}
