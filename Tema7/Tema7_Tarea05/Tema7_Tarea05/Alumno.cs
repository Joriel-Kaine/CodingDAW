using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea05
{
    public class Alumno
    {
        // Campo.
        public string Nombre { get; set; }
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
                    throw new ArgumentOutOfRangeException("La edad debe estar entre 0 y 100.");
                }
            }
        }

        // Constructor.
        public Alumno()
        {
            Nombre = "";
            Edad = 0;
        }

        public Alumno(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método.
        public void Birthday()
        {
            Edad++;
        }

        public void AddNota(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                _notas.Add(nota);
            }
        }

        private string MostrarNotas()
        {
            string texto;

            if (_notas.Count > 0)
            {
                texto = "Notas: ";

                for (int i = 0; i < _notas.Count; i++)
                {
                    if (i != _notas.Count - 1)
                    {
                        texto += $"{_notas[i]} - ";
                    }
                    else
                    {
                        texto += _notas[i];
                    }
                    
                }
            }
            else
            {
                texto = "Alumno sin notas.";
            }

            return texto;
        }

        public string MostrarDatos()
        {
            string texto;

            texto = $"Nombre: {Nombre}\n" +
                    $"Edad: {Edad}\n" +
                    MostrarNotas();

            return texto;
        }
    }
}
