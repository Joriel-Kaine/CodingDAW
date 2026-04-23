using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class Redactor : Profesional
    {
        // Constante.
        const int TarifaHora = 200;


        // Propiedades públicas.
        public string TematicaPrincipal { get; set; }
        public double PrecioPorPalabra { get; set; }


        // Constructor con parámetros de entrada.
        public Redactor(string nombre, string dni, string email, string telefono, string tematicaPrincipal,
                        double precioPorPalabra) : base(nombre, dni, email, telefono)
        {
            TematicaPrincipal = tematicaPrincipal;
            PrecioPorPalabra = precioPorPalabra;
        }


        // Métodos que sobreescriben los métodos de la clase base.
        public override string MostrarTipo()
        {
            return "REDACTOR" +
                   "════════";
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Especialidad: {TematicaPrincipal}" +
                   $"Tarifa por hora: {PrecioPorPalabra}";
        }

        public override double CalcularPresupuesto()
        {
            return PrecioPorPalabra * TarifaHora;
        }
    }
}
