using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCajaTexto.Text = "Se ha pulsado el " + btnPrimero.Text;
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            txtCajaTexto.Text = "Se ha pulsado el " + btnSegundo.Text;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCajaTexto.Clear();
        }
    }
}
