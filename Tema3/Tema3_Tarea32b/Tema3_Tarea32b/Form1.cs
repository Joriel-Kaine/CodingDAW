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
            // Declaramos booleanos tanto para el TryParse como para manejar las salidas según el caso.
            bool esCorrecto = false;
            bool esSalida = false;
            int entradas = 0;
            int totalEntradas = 0;

            while (totalEntradas < MaxAforo && !esSalida)
            {
                esCorrecto = int.TryParse(Interaction.InputBox("Introduce el número de entradas que quieres. (Max 50)",
                    "Entradas", "número"), out entradas);

                if (esCorrecto)
                {
                    // Si el valor es -1, el booleano cambia a True y sale del bucle.
                    if (entradas == -1)
                    {
                        esSalida = true;
                    }
                    // Si supera el aforo máximo, sale un mensaje y te insta a introducir de nuevo otro número válido.
                    else if (totalEntradas + entradas > MaxAforo)
                    {
                        MessageBox.Show($"No es posible el acceso, se supera el aforo. Quedan {MaxAforo - totalEntradas} entradas.");
                    }
                    // Si no supera el aforo y el número no es -1, almacena la cantidad introducida.
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

            /*
             * Si el booleano de esSalida es True, entonces muestra el total de entradas.
             * Si no, el aforo se ha completado al máximo y te muestra el mensaje correspondiente.
             */
            if (esSalida)
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
