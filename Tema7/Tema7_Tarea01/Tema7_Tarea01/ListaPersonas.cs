using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea01
{
    public class ListaPersonas
    {
        private List<Persona> _lista;

        // Constructor.
        public ListaPersonas()
        {
            _lista = new();
        }

        // Métodos.
        public void AddPersona(string nombre, int edad, string telefono, Genero sexo, bool esCasado)
        {
            Persona persona = new(nombre, edad, telefono, sexo, esCasado);

            _lista.Add(persona);
        }

        public string MostrarListaPersonas()
        {
            string texto = "Nombre - Edad - Teléfono - Género - ¿Casado?\n\n";

            foreach (Persona persona in _lista)
            {
                texto += persona.MostrarDatos();
            }

            return texto;
        }
    }
}
