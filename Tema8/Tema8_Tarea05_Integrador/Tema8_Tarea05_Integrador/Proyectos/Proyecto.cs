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
        // Lista privada.
        private List<Profesional> _listaProfesionales = new();


        // Propiedades públicas.
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Duracion { get; set; }

        // Propiedad pública con solo get, para devolver un string formado.
        public string ComboBoxProyecto => $"{Nombre} ({Codigo})";


        // Constructor con parámetros de entrada.
        public Proyecto(string nombre, int codigo, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Duracion = duracion;
        }


        // Método.
        public override string ToString()
        {
            return $"Nombre: {Nombre} - \n" +
                   $"Código: {Codigo} - \n" +
                   $"Duración: {Duracion}";
        }

        public void AddProfesional(Profesional profesional)
        {
            if (!_listaProfesionales.Contains(profesional))
            {
                _listaProfesionales.Add(profesional);
            }
        }
    }
}
