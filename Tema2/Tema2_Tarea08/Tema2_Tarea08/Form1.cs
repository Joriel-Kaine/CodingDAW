using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);
                bool resultado;

                resultado = num1 > num2;
                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes introducir un valor numérico.", "Error de formato");
            }
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);
                bool resultado;

                resultado = num1 < num2;
                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes introducir un valor numérico.", "Error de formato");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);
                bool resultado;

                resultado = num1 == num2;
                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes introducir un valor numérico.", "Error de formato");
            }
        }

        private void btnDiferente_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);
                bool resultado;

                resultado = num1 != num2;
                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes introducir un valor numérico.", "Error de formato");
            }
        }
    }
}
