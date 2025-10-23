using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema3_Tarea17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            try
            {
                int numero, mayor, menor;

                numero = int.Parse(Interaction.InputBox("Introduce un número entero", "Tarea 17", "numero"));

                if (numero >= 0)
                {
                    mayor = numero;
                    menor = numero;

                    while (numero >= 0)
                    {
                        if (numero >= mayor)
                        {
                            mayor = numero;
                        }
                        if (numero <= menor)
                        {
                            menor = numero;
                        }

                        numero = int.Parse(Interaction.InputBox("Introduce un número entero", "Tarea 17", "numero"));
                    }

                    MessageBox.Show($"El número mayor es: {mayor}\n" +
                                    $"El número menor es: {menor}", "número mayor y número menor");
                }
                else
                {
                    MessageBox.Show("Introduce un número entero positivo.", "Número no válido");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un número entero válido.", "Error de formato");
            }
        }
    }
}
