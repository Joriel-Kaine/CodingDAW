using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Tarea09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            try
            {
                int A = int.Parse(txtA.Text);
                int B = int.Parse(txtB.Text);

                bool positivo, cero, menor;

                positivo = (A > 0) && (B > 0);
                cero = (A == 0) || (B == 0);
                menor = (A < B) && (B < 100);

                lblPositivo.Text = ($"Ambos positivos:  {positivo.ToString()}");
                lblCero.Text = ($"Alguno es cero:  {cero.ToString()}");
                lblMenor.Text = ($"A < B y B < 100:  {menor.ToString()}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes introducir un valor numérico.", "Error de formato");
            }
            finally
            {
                txtA.Clear();
                txtB.Clear();

                txtA.Focus();
            }

        }
    }
}
