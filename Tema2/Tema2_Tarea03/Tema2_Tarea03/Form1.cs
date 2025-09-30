using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declarar las variables numéricas.
            float num1 = 3.1416F;
            double num2 = 223.2500;
            decimal num3 = 223.25m;

            // Mostrar los valores en los cuadros de texto.
            MessageBox.Show("float (32 bits, F): " + num1.ToString() + "\n" +
                            $"double (64 bits): {num2} \n" +
                            "decimal (128 bits, m): " + num3.ToString(),
                            "Reales: float / double / decimal");
        }
    }
}
