using Microsoft.VisualBasic;

namespace Tema3_Tarea32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MaxAforo = 50;

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            bool esCorrecto = false;
            int entradas;
            int totalEntradas = 0;

            while (totalEntradas <= MaxAforo)
            {
                esCorrecto = int.TryParse(Interaction.InputBox("Introduce el número de entradas que quieres" +
                    "Pulsa -1 para salir.", "Entradas", "número"), out entradas);

                if (esCorrecto)
                {
                    if (entradas == -1)
                    {
                        MessageBox.Show($"Número total de asistentes registrados: {totalEntradas}");
                        break;
                    }

                    if (totalEntradas + entradas > MaxAforo)
                    {
                        MessageBox.Show($"No es posible el acceso, se supera el aforo.\n" +
                                        $"Quedan {MaxAforo - totalEntradas} entradas disponibles.");
                    }
                    else
                    {
                        totalEntradas += entradas;
                    }

                    if (MaxAforo == totalEntradas)
                    {
                        MessageBox.Show("Aforo completado.");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Introduce un valor númerico válido.");
                }
            }
        }
    }
}
