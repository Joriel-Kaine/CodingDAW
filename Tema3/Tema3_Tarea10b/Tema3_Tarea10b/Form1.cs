using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea10b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dinero = int.Parse(txtValor.Text);

            if (dinero >= 10000)
            {
                int resultado = dinero / 10000;
                lblResultado.Text = $"{resultado} billetes de 10.000 pesetas.\n\n";
                dinero -= resultado * 10000;
            }

            if (dinero >= 5000)
            {
                int resultado = dinero / 5000;
                lblResultado.Text += $"{resultado} billetes de 5.000 pesetas.\n\n";
                dinero -= resultado * 5000;
            }

            if (dinero >= 2000)
            {
                int resultado = dinero / 2000;
                lblResultado.Text += $"{resultado} billetes de 2.000 pesetas.\n\n";
                dinero -= resultado * 2000;
            }

            if (dinero >= 1000)
            {
                int resultado = dinero / 1000;
                lblResultado.Text += $"{resultado} billetes de 1.000 pesetas.\n\n";
                dinero -= resultado * 1000;
            }

            if (dinero >= 100)
            {
                int resultado = dinero / 100;
                lblResultado.Text += $"{resultado} billetes de 100 pesetas.\n\n";
                dinero -= resultado * 100;
            }

            if (dinero >= 25)
            {
                int resultado = dinero / 25;
                lblResultado.Text += $"{resultado} billetes de 25 pesetas.\n\n\n\n";
                dinero -= resultado * 25;
            }

            if (dinero != 0)
            {
                MessageBox.Show($"El dinero restante perdido es de {dinero} pesetas.", "Dinero perdido");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtValor.Clear();
            txtValor.Focus();
        }
    }
}
