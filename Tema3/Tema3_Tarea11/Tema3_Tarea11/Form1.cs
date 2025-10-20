using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal dinero = decimal.Parse(txtValor.Text);
            decimal quinientos = 0, doscientos = 0, cincuenta = 0, veinte = 0,
                    diez = 0, cinco = 0, dos = 0, uno = 0, cincuentaCent = 0,
                    veinteCent = 0, diezCent = 0, cincoCent = 0, dosCent = 0;

            while (dinero > 1)
            {
                if (dinero >= 500)
                {
                    quinientos = dinero / 500;
                }
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
