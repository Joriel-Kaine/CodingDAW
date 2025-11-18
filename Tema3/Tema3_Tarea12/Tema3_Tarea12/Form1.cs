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

            if ((segundo >= 0 && segundo <= 59) && (minuto >= 0 && minuto <= 59) && (hora >= 0 && hora <= 23))
            {
                segundo++;
                /* Hacemos una comprobación para ver si el siguiente segundo no llega a los 60 segundos.
                 * Si lo hace, añadimos un minuto más y reseteamos el contador de segundos a 0.
                 */
                if (segundo == 60)
                {
                    minuto++;
                    segundo -= segundo;

                    /* Hacemos la misma comprobación, pero esta vez nos aseguramos de resetear los minutos después
                     * de haber comprobado que se ha llegado a 60 minutos.
                     */
                    if (minuto == 60)
                    {
                        hora++;
                        minuto -= minuto;

                        // Resetamos las horas a 0.
                        if (hora == 24)
                        {
                            hora -= hora;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Introduce valores correctos dentro del rango.", "Valores incorrectos");
                }
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
