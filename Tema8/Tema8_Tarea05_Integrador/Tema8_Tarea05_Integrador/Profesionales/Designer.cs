using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class Designer : Profesional
    {
        // Propiedades públicas.
        public string Especialidad { get; set; }
        public double TarifaHora { get; set; }


        // Constructor con parámetros de entrada.
        public Designer(string nombre, string dni, string email, string telefono, string especialidad,
                        double tarifaHora) : base(nombre, dni, email, telefono)
        {
            Especialidad = especialidad;
            TarifaHora = tarifaHora;
        }


        // Métodos que sobreescriben los métodos de la clase base.
        public override string MostrarTipo()
        {
            return "Diseñador: ";
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"{Especialidad} - \n" +
                   $"{TarifaHora:C2}";
        }

        public override double CalcularPresupuesto()
        {
            return TarifaHora;
        }
    }
}
