using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class Designer : Profesional
    {
        // Campos privados.
        private string _especialidad;
        private double _tarifaHora;


        // Propiedades públicas de los campos privados.
        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public double TarifaHora
        {
            get { return _tarifaHora; }
            set { _tarifaHora = value; }
        }


        // Constructor con parámetros de entrada.
        public Designer(string nombre, string dni, string telefono, string especialidad,
                        double tarifaHora) : base(nombre, dni, telefono)
        {
            _especialidad = especialidad;
            _tarifaHora = tarifaHora;
        }


        // Métodos que sobreescriben los métodos de la clase base.
        public override string MostrarTipo()
        {
            return "DISEÑADOR" +
                   "═════════";
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
