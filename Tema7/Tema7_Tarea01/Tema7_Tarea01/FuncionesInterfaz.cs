using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea01
{
    public static class FuncionesInterfaz
    {
        const string Mensaje = "Introduce valores válidos.";

        private static int LeerEntero(string mensaje)
        {
            int num;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);

                esCorrecto = int.TryParse(texto, out num);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
                }

            } while (!esCorrecto);

            return num;
        }

        public static void LeerPersona(ListaPersonas listaPersonas)
        {
            string nombre, telefono, tipoGenero, casado;
            int edad;
            Genero sexo = Genero.NoIndicado;
            bool esCasado = false, esCorrecto = false;

            nombre = Interaction.InputBox("Introduce el nombre:");
            edad = LeerEntero("Introduce la edad");
            telefono = Interaction.InputBox("Introduce el número de teléfono:");

            do
            {
                tipoGenero = Interaction.InputBox("Introduce el género: Masculino(M), Femenino(F), No Indicado(NI)");
                switch (tipoGenero.ToUpper())
                {
                    case "M":
                        sexo = Genero.Masculino;
                        esCorrecto = true;
                        break;
                    case "F":
                        sexo = Genero.Femenino;
                        esCorrecto = true;
                        break;
                    case "NI":
                        sexo = Genero.NoIndicado;
                        esCorrecto = true;
                        break;
                    default:
                        MessageBox.Show(Mensaje, "Opción Incorrecta");
                        break;
                }

            } while (!esCorrecto);

            esCorrecto = false;

            do
            {
                casado = Interaction.InputBox("¿Está casado?: (S/N)");
                switch (casado.ToUpper())
                {
                    case "S":
                        esCasado = true;
                        esCorrecto = true;
                        break;
                    case "N":
                        esCasado = false;
                        esCorrecto = true;
                        break;
                    default:
                        MessageBox.Show(Mensaje, "Opcion Incorrecta");
                        break;
                }

            } while (!esCorrecto);

            listaPersonas.AddPersona(nombre, edad, telefono, sexo, esCasado);
        }
    }
}
