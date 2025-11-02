using Microsoft.VisualBasic;

namespace Tema3_Tarea32b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MaxAforo = 50;

        private void btnControlAforo_Click(object sender, EventArgs e)
        {
            bool esCorrecto = false;
            bool esAforoSuperado = false;
            bool esSalida = false;
            int entradas = 0;
            int totalEntradas = 0;

            while (totalEntradas < MaxAforo && !esSalida && !esAforoSuperado)
            {
                esCorrecto = int.TryParse(Interaction.InputBox("Introduce el lnúmero de entradas que quieres.",
                    "Entradas", "número"), out entradas);

                if (esCorrecto)
                {
                    if (entradas == -1)
                    {
                        esSalida = true;
                    }
                    else if (totalEntradas + entradas > MaxAforo)
                    {
                        esAforoSuperado = true;
                    }
                    else if (totalEntradas < MaxAforo && entradas != -1)
                    {
                        totalEntradas += entradas;
                    }
                }
                else
                {
                    MessageBox.Show("Introduce un valor númerico válido.");
                }
            }
            if (esAforoSuperado)
            {
                MessageBox.Show($"No es posible el acceso, se supera el aforo. Quedan {MaxAforo - totalEntradas} entradas.");
            }
            else if (esSalida)
            {
                MessageBox.Show($"Número total de asistentes registrados: {totalEntradas}");
            }
            else
            {
                MessageBox.Show("Aforo completado.");
            }
        }
    }
}
