using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea01
{
    // Declaramos el enumerado para el género.
    public enum Genero
    {
        Masculino,
        Femenino,
        NoIndicado
    }

    public class Persona
    {
        // Declaración de miembros de la clase (camelCase).
        private string _nombre;
        private int _edad;
        private string _telefono;
        private Genero _sexo;
        private bool _casado;

        // Propiedades de la clase (PascalCase).
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value != "")
                {
                    _nombre = value;
                }
                else
                {
                    throw new Exception("Debes introducir un nombre");
                }
            }
        }

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

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Genero Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public bool Casado
        {
            get { return _casado; }
            set { _casado = value; }
        }

        // Constructor.
        public Persona()
        {
            _nombre = "";
            _edad = 0;
            _telefono = "";
            _sexo = Genero.NoIndicado;
            _casado = false;
        }

        public Persona(string nombre, int edad, string telefono, Genero sexo, bool EsCasado)
        {
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Sexo = sexo;
            Casado = EsCasado;
        }

        // Métodos de la clase (PascalCase).
        public string MostrarDatos()
        {
            string texto = "";

            texto = $"{Nombre} - {Edad} - {Telefono} - {Sexo} - {Casado}\n";

            return texto;
        }
    }
}
