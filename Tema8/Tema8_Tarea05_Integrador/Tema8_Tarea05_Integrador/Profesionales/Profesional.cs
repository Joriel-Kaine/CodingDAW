using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema8_Tarea05_Integrador.Proyectos;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public abstract class Profesional
    {
        // Lista privada.
        private List<Proyecto> _listaProyectos = new();


        // Propiedades públicas.
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }


        // Propiedad pública con solo get, para devolver un string formado.
        public string ComboBoxProfesional => $"{Nombre} ({DNI})";


        // Constructor con parámetros de entrada.
        public Profesional(string nombre, string dni, string email, string telefono)
        {
            Nombre = nombre;
            DNI = dni;
            Email = email;
            Telefono = telefono;
        }


        // Método virtual que será reescrito en las clases heredadas.
        public virtual string MostrarTipo()
        {
            return "Profesional: ";
        }

        // Método que sobreescribe el método heredado de System.Object
        public override string ToString()
        {
            return $"{MostrarTipo()}" +
                   $"{Nombre} - \n" +
                   $"{DNI} - \n" +
                   $"{Email} - \n" +
                   $"{Telefono} - \n ";
        }

        // Método abstracto (sin cuerpo) para calcular el presupuesto.
        public abstract double CalcularPresupuesto();

        public bool AddProyecto(Proyecto proyecto)
        {
            bool esCorrecto = false;

            if (!_listaProyectos.Contains(proyecto))
            {
                _listaProyectos.Add(proyecto);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public List<Proyecto> DevolverListaProyectosProfesional()
        {
            return _listaProyectos;
        }
    }
}
