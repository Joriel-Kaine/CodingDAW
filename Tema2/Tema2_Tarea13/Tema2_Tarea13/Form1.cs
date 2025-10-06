using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Estacion
        {
            Primavera = 1,
            Verano,
            Otoño,
            Invierno
        }

        private void btnPrimavera_Click(object sender, EventArgs e)
        {
            Estacion est = Estacion.Primavera;
            MessageBox.Show("Estación: " + est.ToString() + " (" + (int)est + ")");
        }

        private void btnVerano_Click(object sender, EventArgs e)
        {
            Estacion est = Estacion.Verano;
            MessageBox.Show("Estación: " + est.ToString() + " (" + (int)est + ")");
        }

        private void btnOtono_Click(object sender, EventArgs e)
        {
            Estacion est = Estacion.Otoño;
            MessageBox.Show("Estación: " + est.ToString() + " (" + (int)est + ")");
        }

        private void btnInvierno_Click(object sender, EventArgs e)
        {
            Estacion est = Estacion.Invierno;
            MessageBox.Show("Estación: " + est.ToString() + " (" + (int)est + ")");
        }
    }
}
