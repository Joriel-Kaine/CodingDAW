using Microsoft.VisualBasic;

namespace Tema6_Ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int LeerNumero(string mensaje)
        {
            int num;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje, "Leer vector");

                esCorrecto = int.TryParse(texto, out num);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
                }

            } while (!esCorrecto);

            return num;
        }

        const int Tamano = 5;

        // Declaramos y damos tamaño al vector.
        int[] vector = new int[Tamano];

        void LeerVector(int[] vector)
        {
            string mensaje = "";

            for (int i = 0; i < vector.Length; i++)
            {
                mensaje = $"Introduce el valor de la posición {i}: ";

                vector[i] = LeerNumero(mensaje);
            }
        }

        string MostrarVector(int[] vector)
        {
            string texto;
            texto = "Elementos del vector: \n";

            for (int i = 0; i < vector.Length; i++)
            {
                texto += $"{vector[i]}, ";
            }

            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            LeerVector(vector); 
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto;

            texto = MostrarVector(vector);

            MessageBox.Show(texto, "Mostrar Vector");
        }
    }
}

