using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea02.Interfaz
{
    public static class FuncionesInterfaz
    {
        public static int LeerEntero(string mensaje)
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
                    MessageBox.Show("Introduce valores numéricos válidos");
                }

            } while (!esCorrecto);

            return num;
        }

        public static string LeerTexto(string mensaje)
        {
            string texto;
            bool esCorrecto;

            do
            {
                esCorrecto = true;
                texto = Interaction.InputBox(mensaje);

                if (string.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("No se permiten textos vacíos o nulos.");
                    esCorrecto = false;
                }
                else if (!texto.All(char.IsLetter))
                {
                    MessageBox.Show("Introduce textos válidos.");
                    esCorrecto = false;
                }

            } while (!esCorrecto);

            return texto;
        }
    }
}
