using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema7_Tarea06_Integrador
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
                    MessageBox.Show("Introduce valores numéricos válidos.", "ERROR FORMATO");
                }

            } while (!esCorrecto);

            return num;
        }

        public static int LeerEdad(string mensaje)
        {
            int edad;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);
                esCorrecto = int.TryParse(texto, out edad);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.", "ERROR FORMATO");
                }

                if (edad < 0 || edad > 100)
                {
                    MessageBox.Show("La edad debe estar entre 0 y 100.", "ERROR EDAD");
                }

            } while (!esCorrecto || (edad < 0 || edad > 100));

            return edad;
        }

        public static string LeerNombre(string mensaje)
        {
            int num;
            string nombre;
            bool esCorrecto;

            do
            {
                nombre = Interaction.InputBox(mensaje);
                esCorrecto = int.TryParse(nombre, out num);

                if (nombre.Trim() == "")
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "ERROR NOMBRE");
                }

                if (esCorrecto)
                {
                    MessageBox.Show("Introduce un nombre válido.", "ERROR FORMATO");
                }

            } while (nombre.Trim() == "" || esCorrecto);

            return nombre;
        }

        public static double LeerNota(string mensaje)
        {
            double nota;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);
                esCorrecto = double.TryParse(texto, out nota);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.", "ERROR FORMATO");
                }

                if (nota < 0 || nota > 10)
                {
                    MessageBox.Show("La nota debe estar entre 0 y 10.", "ERROR RANGO");
                }

            } while (!esCorrecto || (nota < 0 || nota > 10));

            return nota;
        }

        private static bool ContieneNum(char caracter)
        {
            bool esCorrecto = false;

            if (caracter >= '0' && caracter <= '9')
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        private static bool ContieneLetra(char caracter)
        {
            bool esCorrecto = false;

            if (caracter >= 'A' && caracter <= 'Z')
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public static string LeerDNI(string mensaje)
        {
            string dni, parteNum, parteLetra;

            do
            {
                parteNum = ""; parteLetra = "";

                dni = Interaction.InputBox(mensaje);

                for (int i = 0; i < dni.Length; i++)
                {
                    if (ContieneNum(dni[i]) && parteNum.Length <= 8)
                    {
                        parteNum += dni[i];
                    }

                    if (i == dni.Length - 1 && ContieneLetra(char.ToUpper(dni[i])))
                    {
                        parteLetra += char.ToUpper(dni[i]);
                    }
                }

                if (parteNum.Length != 8 || parteLetra.Length != 1)
                {
                    MessageBox.Show("Introduce un número de identidad válido.", "ERROR FORMATO");
                }

            } while (parteNum.Length != 8 || parteLetra.Length != 1);

            dni = parteNum + parteLetra;

            return dni;
        }
    }
}
