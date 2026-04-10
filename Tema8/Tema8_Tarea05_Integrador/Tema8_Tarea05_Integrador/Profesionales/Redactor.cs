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
        private string _tematicaPrincipal;
        private double _precioPorPalabra;


        // Propiedades públicas de los campos privados.
        public string TematicaPrincipal
        {
            get { return _tematicaPrincipal; }
            set { _tematicaPrincipal = value; }
        }

        public double PrecioPorPalabra
        {
            get { return _precioPorPalabra; }
            set { _precioPorPalabra = value; }
        }


        // Constructor con parámetros de entrada.
        public Redactor(string nombre, string dni, string telefono, string tematicaPrincipal,
                        double precioPorPalabra) : base(nombre, dni, telefono)
        {
            _tematicaPrincipal = tematicaPrincipal;
            _precioPorPalabra = precioPorPalabra;
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
