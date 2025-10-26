using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            string tabla;

            for (int i = 1; i <= 10; i++)
            {
                tabla = "";

                for (int j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    tabla += $"{i} * {j} = {resultado}\n";
                }

                MessageBox.Show(tabla, $"Tabla del {i}");
            }
        }
    }
}
