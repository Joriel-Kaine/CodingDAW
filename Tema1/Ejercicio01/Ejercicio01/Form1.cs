using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha apretado el primer botón.");
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha apretado el segundo botón.");
        }
    }
}
