using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            bool entrada;
            int resultado = 0;
            string tabla = "";

            entrada = int.TryParse(txtNumero.Text, out int numero);

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                tabla += $"{numero} * {i} = {resultado}\n";
            }

            MessageBox.Show($"Tabla del {numero}\n\n" +
                            $"{tabla}", "Tabla de multiplicar");
        }
    }
}
