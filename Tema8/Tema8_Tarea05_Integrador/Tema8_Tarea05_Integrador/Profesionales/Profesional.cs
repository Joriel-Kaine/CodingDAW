using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public abstract class Profesional
    {
        // Campos privados.
        private string _nombre;
        private string _dni;
        private string _telefono;


        // Propiedades públicas de los campos privados.
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


        // Constructor con parámetros de entrada.
        public Profesional(string nombre, string dni, string telefono)
        {
            _nombre = nombre;
            _dni = dni;
            _telefono = telefono;
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
            return $"Nombre: {Nombre} \n" +
                   $"DNI: {DNI} \n" +
                   $"Teléfono: {Telefono} ";
        }

        // Método abstracto (sin cuerpo) para calcular el presupuesto.
        public abstract double CalcularPresupuesto();
    }
}
