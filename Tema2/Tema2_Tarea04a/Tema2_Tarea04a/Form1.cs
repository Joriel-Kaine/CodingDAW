using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea04a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal precio = decimal.Parse(txtPrecio.Text);
                decimal descuento = decimal.Parse(txtDescuento.Text);

                decimal neto = precio * (1 - descuento);

                lblNeto.Text = $"Neto: {neto.ToString("C2")} ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce valores númericos válidos en Precio y Descuento.",
                                "Error de formato");
            }
        }
    }
}
