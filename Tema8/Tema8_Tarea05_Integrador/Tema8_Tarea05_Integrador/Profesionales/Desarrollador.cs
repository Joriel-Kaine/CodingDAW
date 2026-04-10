using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Profesionales
{
    public class Desarrollador : Profesional
    {
        // Campos privados.
        private string _lenguajePrincipal;
        private double _tarifaHora;


        // Propiedades públicas de los campos privados.
        public string LenguajePrincipal
        {
            get { return _lenguajePrincipal; }
            set { _lenguajePrincipal = value; }
        }

        public double TarifaHora
        {
            get { return _tarifaHora; }
            set { _tarifaHora = value; }
        }


        // Constructor con parámetros de entrada.
        public Desarrollador(string nombre, string dni, string telefono, string lenguajePrincipal,
                        double tarifaHora) : base(nombre, dni, telefono)
        {
            _lenguajePrincipal = lenguajePrincipal;
            _tarifaHora = tarifaHora;
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
