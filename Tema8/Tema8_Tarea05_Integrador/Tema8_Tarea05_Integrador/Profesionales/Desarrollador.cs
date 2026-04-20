using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class Desarrollador : Profesional
    {
        // Propiedades públicas.
        public string LenguajePrincipal { get; set; }
        public double TarifaHora { get; set; }


        // Constructor con parámetros de entrada.
        public Desarrollador(string nombre, string dni, string email, string telefono, string lenguajePrincipal,
                        double tarifaHora) : base(nombre, dni, email, telefono)
        {
            LenguajePrincipal = lenguajePrincipal;
            TarifaHora = tarifaHora;
        }


        // Métodos que sobreescriben los métodos de la clase base.
        public override string MostrarTipo()
        {
            return "DESARROLLADOR" +
                   "═════════════";
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
