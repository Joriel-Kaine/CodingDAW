using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2_Integrador_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int Minuto = 60;
        const decimal IVA = 0.21m;
        const decimal USD = 1.1672m;
        const decimal GBP = 0.8740m;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Ponemos un try / catch para atajar los posibles errores en la aplicación.
            try
            {
                // Metemos en variables los minutos que se van a introducir en el textbox.
                int minTrack1 = int.Parse(txtMinTrack1.Text);
                int minTrack2 = int.Parse(txtMinTrack2.Text);
                int minTrack3 = int.Parse(txtMinTrack3.Text);

                // Metemos en variables los segundos que se van a introducir en el textbox.
                int secTrack1 = int.Parse(txtSegTrack1.Text);
                int secTrack2 = int.Parse(txtSegTrack2.Text);
                int secTrack3 = int.Parse(txtSegTrack3.Text);

                // Sumamos el total de segundos y los metemos en una variable.
                int segundosTotal = secTrack1 + secTrack2 + secTrack3;

                // Calculamos el total de minutos y segundos que hay.
                int duracionMinutos = (minTrack1 + minTrack2 + minTrack3) + (segundosTotal / Minuto);
                int duracionSegundos = (secTrack1 + secTrack2 + secTrack3) % Minuto;

                // Mostramos en el label el resultado de la suma.
                lblDuracionTotal.Text = $"Duración total: {duracionMinutos:D2}:{duracionSegundos:D2}";

                // Metemos en una variable el precio base.
                decimal precioBase = decimal.Parse(txtPrecioBase.Text);

                // Metemos en una variable el descuento.
                decimal descuento = decimal.Parse(txtDescuento.Text);

                // Calculamos el neto y el IVA.
                decimal neto = precioBase - (precioBase * descuento);
                decimal iva = neto * IVA;

                // Calculamos el total en euros, en dólares y en libras.
                decimal totalEuros = neto + iva;
                decimal totalDolares = totalEuros * USD;
                decimal totalLibras = totalEuros * GBP;

                // Mostramos en los label los resultados de las operaciones.
                lblNeto.Text = $"Neto: {neto:C2}";
                lblIVA.Text = $"IVA: {iva:C2}";
                lblTotalEUR.Text = $"Total (EUR): {totalEuros:C2}";
                lblTotalUSD.Text = $"Total (USD): {totalDolares:N2}";
                lblTotalGBP.Text = $"Total (GBP): {totalLibras:N2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce un valor numérico válido.", "Error de formato");
            }
            finally
            {
                txtMinTrack1.Focus();
            }
        }
    }
}
