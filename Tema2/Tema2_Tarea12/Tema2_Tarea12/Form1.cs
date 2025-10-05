using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPeseta_Click(object sender, EventArgs e)
        {
            try
            {
                double euro = double.Parse(txtEuro.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un valor numérico válido.", "Error de formato");
            }
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            try
            {
                double peseta = double.Parse(txtPeseta.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un valor numérico válido", "Error de formato");
            }
        }
    }
}
