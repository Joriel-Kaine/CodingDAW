using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea04
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
                    MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
                }

            } while (!esCorrecto);

            return num;
        }

        public static string LeerNombre()
        {
            string texto;

            return texto = Interaction.InputBox("Introduce el nombre: ");
        }

        public static double LeerNota(string mensaje)
        {
            double nota;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox("Introduce la nota: ");
                esCorrecto = double.TryParse(texto, out nota);

                if ((nota < 0 || nota > 10) && !esCorrecto)
                {
                    MessageBox.Show("La nota debe ser numérica y entre 0 y 10.", "Error de formato");
                }

            } while (!esCorrecto);

            return nota;
        }


    }
}
