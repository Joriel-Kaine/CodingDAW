using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valor;
            int factorial = 1;

            if (valor = int.TryParse(txtNumero.Text, out int numero))
            {
                for (int i = numero; i > 0; i--)
                {
                    factorial *= i;
                }

                MessageBox.Show($"El factorial de {numero} es: {factorial}");
            }
            else
            {
                MessageBox.Show($"Debes introducir un número entero válido.");
            }

        }
    }
}
