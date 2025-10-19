using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dinero = int.Parse(txtValor.Text);
            int diezMil = 0, cincoMil = 0, dosMil = 0,
                mil = 0, cien = 0, veintiCinco = 0;

            while (dinero >= 25)
            {
                if (dinero >= 10000)
                {
                    diezMil = dinero / 10000;
                    dinero -= diezMil * 10000;
                }
                else if (dinero >= 5000)
                {
                    cincoMil = dinero / 5000;
                    dinero -= cincoMil * 5000;
                }
                else if (dinero >= 2000)
                {
                    dosMil = dinero / 2000;
                    dinero -= dosMil * 2000;
                }
                else if (dinero >= 1000)
                {
                    mil = dinero / 1000;
                    dinero -= mil * 1000;
                }
                else if (dinero >= 100)
                {
                    cien = dinero / 100;
                    dinero -= cien * 100;
                }
                else
                {
                    veintiCinco = dinero / 25;
                    dinero -= veintiCinco * 25;
                }
            }

            lblResultado.Text = ($"{diezMil} billetes de 10.000 pesetas\n" +
                                $"{cincoMil} billetes de 5.000 pesetas\n" +
                                $"{dosMil} billetes de 2.000 pesetas\n" +
                                $"{mil} billetes de 1.000 pesestas\n" +
                                $"{cien} monedas de 100 pesetas\n" +
                                $"{veintiCinco} monedas de 25 pesetas");

            MessageBox.Show($"Se han perdido {dinero} pesetas por el camino.", "Dinero perdido");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtValor.Clear();
            txtValor.Focus();
        }
    }
}
