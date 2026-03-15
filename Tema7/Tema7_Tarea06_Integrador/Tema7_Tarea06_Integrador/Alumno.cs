using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
{
    public class Alumno
    {
        // Campos.
        public string Nombre { get; set; }
        private int _edad;
        public string DNI { get; set; }
        public int CodCurso { get; set; }
        private List<double> _listaNotas = new();



        // Propiedades.
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



        // Constructores.
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



        // Métodos.
        public void Birthday()
        {
            Edad++;
        }

        public void AddNota(double nota)
        {
            _listaNotas.Add(nota);
        }

        private string GenerarTextoNotas()
        {
            string texto;

            if (_listaNotas.Count > 0)
            {
                texto = "Notas: ";

                for (int i = 0; i < _listaNotas.Count; i++)
                {
                    if (i != _listaNotas.Count - 1)
                    {
                        texto += $"{_listaNotas[i]} - ";
                    }
                    else
                    {
                        texto += _listaNotas[i];
                    }
                }
            }
            else
            {
                texto = "Alumno sin notas.";
            }

            return texto;
        }

        public string GenerarTextoDatos()
        {
            return $"Nombre: {Nombre}\n" +
                   $"Edad: {Edad}\n" +
                   $"DNI: {DNI}\n" +
                   $"Código de curso: {CodCurso}\n" +
                   GenerarTextoNotas();
        }

        private double SumaNotas()
        {
            double suma = 0.0;

            for (int i = 0; i < _listaNotas.Count; i++)
            {
                suma += _listaNotas[i];
            }

            return suma;
        }

        public double MediaNotas()
        {
            double media = 0.0;

            if (_listaNotas.Count > 0)
            {
                media = SumaNotas() / _listaNotas.Count;
            }

            return media;
        }
    }
}
