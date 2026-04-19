using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class Redactor : Profesional
    {
        // Campos privados.
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
            return base.ToString();
        }

        public override double CalcularPresupuesto()
        {
            return 0.0;
        }
    }
}
