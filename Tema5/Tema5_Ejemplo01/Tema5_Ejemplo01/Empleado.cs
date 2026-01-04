using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tema5_Ejemplo01
{
    public class Empleado
    {
        // Declaración de miembros de la clase.
        private string _nombre;
        private int _edad;
        // Aquí almacenaremos ventas realizadas por el empleado.
        // Utilizamos el tipo List.
        private List<double> _ventas;

        // Propiedades de la clase.
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set
            {
                // No permitimos edades negativas o superiores a 100.
                if (_edad >= 0 || _edad <= 100)
                {
                    _edad = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("\nLa edad debe estar entre 0 y 100.");
                }
            }
        }

        // Constructor.
        public Empleado()
        {
            _nombre = "";
            _edad = 0;
            // Creamos la lista de ventas.
            _ventas = new List<double>();
        }

        // Métodos de la clase.

        // Cumpleaños del empleado.
        public void Birthday()
        {
            _edad += 1;
        }

        // Añadir una venta al empleado.
        public void AddVenta(double venta)
        {
            if (venta > 0)
            {
                _ventas.Add(venta);
            }
        }

        // Función que devuelve un texto con la lista de ventas.
        // Es privada ya que solo se utilizará dentro de la clase.
        // (en MostrarDatos)
        private string MostrarVentas()
        {
            string texto;
            int i;

            if (_ventas.Count > 0)
            {
                texto = "Las ventas son: ";
                for (i = 0; i < _ventas.Count; i++)
                {
                    texto += $"{_ventas[i]}, ";
                }

                texto += "\n";
            }
            else
            {
                texto = "Empleado sin ventas.\n";
            }

            return texto;
        }

        // Función que devuelve un texto con los datos del empleado.
        // Es pública ya que se le llama desde fuera de la clase.
        public string MostrarDatos()
        {
            string texto;

            texto = "Datos del empleado:\n";
            texto += $"Nombre: {_nombre}\n";
            texto += $"Edad: {_edad}\n";
            texto += MostrarVentas();

            return texto;
        }
    }
}
