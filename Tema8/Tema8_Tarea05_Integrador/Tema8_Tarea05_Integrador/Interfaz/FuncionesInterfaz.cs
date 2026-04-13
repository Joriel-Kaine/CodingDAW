using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8_Tarea05_Integrador.Interfaz
{
    public static class FuncionesInterfaz
    {
        public static bool ValidarDouble(string mensaje, out double num)
        {
            bool esCorrecto = double.TryParse(mensaje, out num);

            if (!esCorrecto)
            {
                MessageBox.Show("Introduce valores numéricos válidos");
            }

            return esCorrecto;
        }

        public static bool ValidarTexto(string mensaje, out string texto)
        {
            bool esCorrecto = true;
            texto = mensaje;

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("No se permiten textos vacíos o nulos.");
                esCorrecto = false;
            }
            else if (!mensaje.All(char.IsLetter))
            {
                MessageBox.Show("Introduce textos válidos.");
                esCorrecto = false;
            }

            return esCorrecto;
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

        public static bool ValidarDNI(string dniEntrada, out string dniSalida)
        {
            string parteNum, parteLetra;
            bool esCorrecto = true;
            
            parteNum = ""; parteLetra = "";
              
            dniEntrada = dniEntrada.Trim().ToUpper();
            
            if (dniEntrada.Length == 9)
            {
                for (int i = 0; i < dniEntrada.Length; i++)
                {

                    if (ContieneNum(dniEntrada[i]) && parteNum.Length < 8)
                    {
                        parteNum += dniEntrada[i];
                    }
                    else if (i == dniEntrada.Length - 1 && ContieneLetra(dniEntrada[i]))
                    {
                        parteLetra += dniEntrada[i];
                    }
                    else
                    {
                        esCorrecto = false;
                    }
                }

                if (parteNum.Length != 8 || parteLetra.Length != 1)
                {
                    esCorrecto = false;

                    MessageBox.Show("Introduce un número de identidad válido.");
                }
            }
            else
            {
                esCorrecto = false;

                MessageBox.Show("El DNI debe componerse de 9 caracteres.");
            }
            
            dniSalida = parteNum + parteLetra;

            return esCorrecto;
        }

        public static string LeerDNI(string mensaje)
        {
            string dni, parteNum, parteLetra;

            do
            {
                parteNum = ""; parteLetra = "";

                dni = Interaction.InputBox(mensaje, " ");
                dni = dni.Trim().ToUpper();

                if (dni.Length == 9)
                {
                    for (int i = 0; i < dni.Length; i++)
                    {
                        if (ContieneNum(dni[i]) && parteNum.Length < 8)
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
                        MessageBox.Show("Introduce un número de identidad válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El DNI debe componerse de 9 caracteres.");
                }

            } while (parteNum.Length != 8 || parteLetra.Length != 1);

            dni = parteNum + parteLetra;

            return dni;
        }
    }
}
