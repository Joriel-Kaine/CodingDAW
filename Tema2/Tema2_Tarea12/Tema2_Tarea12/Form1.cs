using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea12
{
    public partial class Form1 : Form
    {
        const decimal Convert = 166.386m;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnPeseta_Click(object sender, EventArgs e)
        {
            try
            {
                decimal euro = decimal.Parse(txtEuro.Text);

                txtPeseta.Text = (euro * Convert).ToString("N3");
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
                decimal peseta = decimal.Parse(txtPeseta.Text);

                txtEuro.Text = (peseta / Convert).ToString("N3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un valor numérico válido", "Error de formato");
            }
        }
    }
}
