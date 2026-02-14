using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea03
{
    public class Alumno
    {
        public string Nombre { set; get; } // auto-property: sin lógica adiconal.
        private int _edad;
        private List<double> _notas = new();

        // Propiedad.
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value >= 0 && value <= 100)
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
        public Alumno()
        {
            Nombre = "";
            Edad = 0;
        }

        public Alumno (string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método.
        public void Birthday()
        {
            _edad++;
            // Edad++;
        }

        public void AddNota(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                _notas.Add(nota);
            }
            else
            {
                throw new ArgumentOutOfRangeException("\nNota inválida.");
            }
        }

        private string MostrarNotas()
        {
            string texto;

            if (_notas.Count > 0)
            {
                texto = "\nNotas: ";
                
                for (int i = 0; i < _notas.Count; i++)
                {
                    texto += $"{_notas[i]}, ";
                }
                texto += "\n";
            }
            else
            {
                texto = "\nAlumno sin notas.";
            }

            return texto;
        }

        public string MostrarDatos()
        {
            string texto;

            texto = $"\nDatos del alumno:" +
                    $"\nNombre: {Nombre}" +
                    $"\nEdad: {Edad}" +
                    MostrarNotas();

            return texto;
        }
    }
}
