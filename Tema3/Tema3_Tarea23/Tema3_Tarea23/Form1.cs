using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero;
                string resultado = "";

                numero = int.Parse(txtNumero.Text);

                if (numero >= 1 && numero <= 15)
                {
                    for (int i = numero; i >= 1; i--)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            if (j == 10)
                            {
                                resultado += $"{j}";
                            }
                            else
                            {
                                resultado += $"{j}, ";
                            }
                        }

                        resultado += "\n";
                    }

                    MessageBox.Show(resultado, "Resultado");
                }
                else
                {
                    MessageBox.Show("Debes introducir un número entre 1 y 15.", "Rango incorrecto");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes introducir un número entero válido.");
            }
        }
    }
}
