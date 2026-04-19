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
        // Campos privados.
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        private List<Proyecto> _listaProyectos = new();


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
            return "PROFESIONAL" +
                   "═══════════";
        }

        // Método que sobreescribe el método heredado de System.Object
        public override string ToString()
        {
            return $"Nombre: {Nombre} - \n" +
                   $"DNI: {DNI} - \n" +
                   $"Email: {Email} \n" +
                   $"Teléfono: {Telefono} ";
        }

        // Método abstracto (sin cuerpo) para calcular el presupuesto.
        public abstract double CalcularPresupuesto();
    }
}
