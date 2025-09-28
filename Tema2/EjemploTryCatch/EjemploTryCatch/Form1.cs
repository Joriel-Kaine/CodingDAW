using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploTryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click (object sender, EventArgs e)
        {
            int dividendo, divisor;
            int resultado;

            try
            {
                dividendo = int.Parse(txtDividendo.Text);
                divisor = int.Parse(txtDivisor.Text);

                resultado = dividendo / divisor;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException fEx) 
            {
                MessageBox.Show ("Se ha producido el error: " + fEx.Message);
            }
            catch (DivideByZeroException oEx)
            {
                MessageBox.Show (oEx.Message);
            }


        }
    }
}
