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
            bool isTrue = false;
            int entrada;
            int totalEntradas = 0;

            while (totalEntradas < MaxAforo)
            {
                isTrue = int.TryParse(Interaction.InputBox("Introduce el número de entradas que quieres.",
                    "Entradas", "número"), out entrada);

                if (isTrue)
                {
                    if (entrada < MaxAforo || entrada != -1)
                    {
                        totalEntradas += entrada;
                    }
                    MessageBox.Show("Hola");
                }
                else
                {
                    MessageBox.Show("Introduce un valor númerico válido.");
                }
            }

        }
    }
}
