using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class Alumno
    {
        // Campo.
        public string Nombre { get; set; }
        private int _edad;
        public string DNI { get; set; }
        public int CodCurso { get; set; }
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
            DNI = "";
            CodCurso = -1;
        }

        public Alumno(string nombre, int edad, string dni, int codCurso)
        {
            Nombre = nombre;
            Edad = edad;
            DNI = dni;
            CodCurso = codCurso;
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
                    $"DNI: {DNI}\n" +
                    $"Código de curso: {CodCurso}\n" +
                    MostrarNotas();

            return texto;
        }

        private double SumaNotas()
        {
            double suma = 0.0;

            for (int i = 0; i < _notas.Count; i++)
            {
                suma += _notas[i];
            }

            return suma;
        }

        public int CountNotas()
        {
            return _notas.Count;
        }

        public double MediaNotas()
        {
            double media = 0.0;

            if (_notas.Count > 0)
            {
                media = SumaNotas() / CountNotas();
            }

            return media;
        }
    }
}
