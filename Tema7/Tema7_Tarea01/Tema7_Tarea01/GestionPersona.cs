using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea01
{
    public class GestionPersona
    {
        public Persona CrearPersona()
        {
            string nombre = Interaction.InputBox("Introduce el nombre: ", "NOMBRE");
            int edad = Utilidades.LeerEntero("Introduce la edad: ");
            string telefono = Interaction.InputBox("Introduce el número de teléfono: ");

            Persona persona = new(nombre);
        }
    }
}
