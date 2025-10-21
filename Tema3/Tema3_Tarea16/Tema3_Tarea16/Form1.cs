using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                suma += i;
            }

            MessageBox.Show($"La suma de los números del 1 al 10 es: {suma}");
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int i = 1;

            while (i <= 10)
            {
                suma += i;
                i++;
            }

            MessageBox.Show($"La suma de los números del 1 al 10 es: {suma}");
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int i = 1;

            do
            {
                suma += i;
                i++;

            } while (i <= 10);

            MessageBox.Show($"La suma de los números del 1 al 10 es: {suma}");
        }
    }
}
