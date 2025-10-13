using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3_Tarea04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobarNum_Click(object sender, EventArgs e)
        {
            try
            {
                int numSerie = int.Parse(txtNumSerie.Text);

                if ((numSerie >= 14681 && numSerie <= 15681) || 
                    (numSerie >= 70001 && numSerie <= 79999) ||
                    (numSerie >= 88888 && numSerie <= 111111))
                {
                    MessageBox.Show($"El número de serie {numSerie} es defectuoso.", "Número de serie");
                }
                else if (numSerie == 0)
                {
                    MessageBox.Show($"El número de serie no puede ser {numSerie}.", "Número de serie");
                }
                else
                {
                    MessageBox.Show($"El número de serie {numSerie} no es defectuoso.", "Número de serie");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un número de serie válido.", "Error de formato");
            }
        }
    }
}
