using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploVarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaramos la variable Double.
            double numeroDouble;

            // Le damos valor al número Double.
            numeroDouble = 223.25;

            // Lo mostramos por pantalla.
            MessageBox.Show(numeroDouble.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Declaramos la variable Float.
            float numeroFloat;

            // Le damos valor al número Float.
            numeroFloat = 3.1416F;

            // Lo mostramos por pantalla.
            MessageBox.Show(numeroFloat.ToString());
        }
    }
}
