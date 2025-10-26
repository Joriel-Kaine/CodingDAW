using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            int suma = 0;

            for (int i = 3; i <= 100; i+=3)
            {
                if (i + 3 <= 100)
                {
                    if (i % 7 == 0)
                    {
                        resultado += $"{i},\n";
                        suma += i;
                    }
                    else
                    {
                        resultado += $"{i}, ";
                        suma += i;
                    }
                }
                else
                {
                    resultado += $"{i}";
                    suma += i;
                }
            }

            MessageBox.Show($"Serie:\n" +
                            $"{resultado}\n\n" +
                            $"La suma es: {suma}", "Suma y visualización de serie aritmética");
        }
    }
}
