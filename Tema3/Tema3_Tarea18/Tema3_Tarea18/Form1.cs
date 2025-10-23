using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tema3_Tarea18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                int numero;
                int suma = 0;

                numero = int.Parse(Interaction.InputBox("Introduce un número entero positivo", "Tarea 18", "numero"));

                while (numero >= 0 && numero <= 9)
                {
                    suma += numero;

                    numero = int.Parse(Interaction.InputBox("Introduce un número entero positivo", "Tarea 18", "numero"));
                }

                MessageBox.Show($"La suma total de los números introducidos es: {suma}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un número entero válido");
            }
        }
    }
}
