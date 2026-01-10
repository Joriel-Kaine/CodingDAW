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

            do
            {
                mensaje = Interaction.InputBox("Introduzca el elemento: ", "Leer Vector");

                esCorrecto = int.TryParse(mensaje, out num);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce un valor numérico válido.", "Error de formato");
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
                vector[i] = LeerNumero(mensaje) + i;
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
