using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadirTexto_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;

            if (!(int.TryParse(texto, out int numEntero)) &&
                !(decimal.TryParse(texto, out decimal numDecimal)))
            {
                lblAddText.Text += ($"{texto}\n");
            }
            else
            {
                MessageBox.Show("Debes de introducir solo texto...", "Entrada no válida");
            }

            txtTexto.Clear();
            txtTexto.Focus();
        }
    }
}
