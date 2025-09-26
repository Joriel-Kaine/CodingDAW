using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtCuadroTexto.Text);
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            BackColor = Color.CadetBlue;
        }

        private void btnTercero_Click(object sender, EventArgs e)
        {
            txtCuadroTexto.ForeColor = Color.Red;
        }
    }
}
