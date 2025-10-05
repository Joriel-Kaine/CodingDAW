using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtAltura.Text);

                int metros = numero / 100;
                int centimetros = numero - (metros * 100);

                lblResultado.Text = ($"Mide {metros} metros y {centimetros} cms.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un valor numérico válido.", "Error de formato");
            }
        }
    }
}
