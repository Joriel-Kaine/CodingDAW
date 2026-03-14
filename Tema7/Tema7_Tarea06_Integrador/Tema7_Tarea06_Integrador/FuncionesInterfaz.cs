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
                    MessageBox.Show("Introduce valores numéricos válidos.", "");
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
                    MessageBox.Show("Introduce valores numéricos válidos.", "");
                }

                if (esCorrecto && edad < 0 || edad > 100)
                {
                    MessageBox.Show("La edad debe estar entre 0 y 100.", "");
                }

            } while (!esCorrecto || (edad < 0 || edad > 100));

            return edad;
        }

        public static string LeerNombre(string mensaje)
        {
            string nombre;
            bool esCorrecto;

            do
            {
                nombre = Interaction.InputBox(mensaje);
                nombre = nombre.Trim(); // Aseguramos que no hay espacios ni al principio ni al final del nombre.
                esCorrecto = true;

                // Comprobamos si el nombre introducido es una cadena de caracteres vacía.
                if (nombre == "")
                {
                    MessageBox.Show("El nombre no puede estar vacío.", "");
                    esCorrecto = false;
                }

                 /* Recorremos los caracteres del nombre y aseguramos que todos contengan los
                  * caracteres permitidos para un nombre válido en el programa. */

                for (int i = 0; i < nombre.Length; i++) /* Usamos "Length" porque el nombre es un string hecho
                                                         * con un array (vector) de caracteres. */
                {
                    /* En esta condición comprobamos que el valor (caracter) es un espacio en blanco.
                     * Si lo es, se ejecuta la segunda condición y se comprueba la segunda condición.
                     * Aquí comprobamos que el índice + 1 esté dentro del número de valores del string.
                     * Si es correcto, pasamos a la última condición.
                     * Si hay 2 espacios seguidos, el booleano pasa a ser falso. */
                    if (nombre[i] == ' ' && i + 1 < nombre.Length && nombre[i + 1] == ' ')
                    {
                        esCorrecto = false;
                    }

                    // Aquí aseguramos que después del espacio el nombre siga siendo válido.
                    if (nombre[i] != ' ' && !ContieneLetraNombre(nombre[i]))
                    {
                        esCorrecto = false;
                    }
                }


                if (!esCorrecto && nombre != "")
                {
                    MessageBox.Show("Introduce un nombre válido.", "");
                }

            } while (!esCorrecto);

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
                    MessageBox.Show("Introduce valores numéricos válidos.", "");
                }

                if (esCorrecto && nota < 0 || nota > 10)
                {
                    MessageBox.Show("La nota debe estar entre 0 y 10.", "");
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
            caracter = char.ToUpper(caracter);

            if (caracter >= 'A' && caracter <= 'Z')
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        private static bool ContieneLetraNombre(char caracter)
        {
            bool esCorrecto = false;
            caracter = char.ToUpper(caracter);

            if ((caracter >= 'A' && caracter <= 'Z') || caracter == 'Ñ' ||
                caracter == 'Á' || caracter == 'É' || caracter == 'Í' ||
                caracter == 'Ó' || caracter == 'Ú')
            {
                esCorrecto = true;
            }

            return esCorrecto;
        }

        private static bool ContieneLetraNombreCurso(char caracter)
        {
            bool esCorrecto = false;
            caracter = char.ToUpper(caracter);

            if ((caracter >= 'A' && caracter <= 'Z') || caracter == 'Ñ' ||
                caracter == 'Á' || caracter == 'É' || caracter == 'Í' ||
                caracter == 'Ó' || caracter == 'Ú' || caracter == 'º' ||
                caracter == '-')
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

                    if (i == dni.Length - 1 && ContieneLetra(dni[i]))
                    {
                        parteLetra += dni[i];
                    }
                }

                if (parteNum.Length != 8 || parteLetra.Length != 1)
                {
                    MessageBox.Show("Introduce un número de identidad válido.", "");
                }

            } while (parteNum.Length != 8 || parteLetra.Length != 1);

            dni = parteNum + parteLetra;

            return dni;
        }

        public static int LeerCodigoCurso(string mensaje)
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
                    MessageBox.Show("Introduce valores numéricos válidos.", "");
                }

                if (esCorrecto && num < 100 || num > 200)
                {
                    MessageBox.Show("El código tiene que estar entre 100 y 200.", "");
                }

            } while (!esCorrecto || (num < 100 || num > 200));

            return num;
        }
    }
}
