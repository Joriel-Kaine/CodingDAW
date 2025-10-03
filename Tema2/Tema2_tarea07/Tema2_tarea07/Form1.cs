using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_tarea07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int dividendo = int.Parse(txtDividendo.Text);
                int divisor = int.Parse(txtDivisor.Text);

                int cociente = dividendo / divisor;
                lblCociente.Text = ($"Cociente: {cociente}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes introducir valores numéricos.", "Error de formato");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Intento de división por cero.", "Error de divisón por 0");
            }
            finally
            {
                txtDividendo.Clear();
                txtDivisor.Clear();
            }
        }
    }
}
