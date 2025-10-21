using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int hora = int.Parse(txtHora.Text);
            int minuto = int.Parse(txtMinuto.Text);
            int segundo = int.Parse(txtSegundo.Text);

            if (segundo < 59)
            {
                segundo++;
            }
            else
            {
                minuto++;
                segundo -= segundo;
            }

            MessageBox.Show($"La hora siguiente será {hora:D2} : {minuto:D2} : {segundo:D2}", "Nueva hora");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHora.Clear();
            txtMinuto.Clear();
            txtSegundo.Clear();
            txtHora.Focus();
        }
    }
}
