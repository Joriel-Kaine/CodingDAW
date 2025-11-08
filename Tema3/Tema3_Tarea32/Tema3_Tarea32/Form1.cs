using Microsoft.VisualBasic;

namespace Tema3_Tarea32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaramos el máximo aforo como constante.
        const int MaxAforo = 50;

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            bool esCorrecto = false;  // Declaramos una variable booleana para el InputBox.
            int entradas;
            int totalEntradas = 0;

            while (totalEntradas <= MaxAforo)
            {
                /* 
                 * Usamos TryParse para la comprobación de la entrada del valor, debiendo ser numérico.
                 * Si es un número dara True, si es otro valor, dará false.
                 */
                esCorrecto = int.TryParse(Interaction.InputBox("Introduce el número de entradas que quieres" +
                    "Pulsa -1 para salir.", "Entradas", "número"), out entradas);

                // Comprobamos que el número introducido sea válido.
                if (esCorrecto)
                {
                    // Si el valor introducido es -1, muestra el total de entradas y sale del bucle.
                    if (entradas == -1)
                    {
                        MessageBox.Show($"Número total de asistentes registrados: {totalEntradas}");
                        break;
                    }

                    /*
                     * Si el valor supera las el aforo máximo, te insta a que introduzcas un valor dentro del rango.
                     * Si está dentro hace el cálculo necesario.
                     */
                    if (totalEntradas + entradas > MaxAforo)
                    {
                        MessageBox.Show($"No es posible el acceso, se supera el aforo.\n" +
                                        $"Quedan {MaxAforo - totalEntradas} entradas disponibles.");
                    }
                    else
                    {
                        totalEntradas += entradas;
                    }

                    // Si el aforo se completa, te avisa que se ha completado.
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
