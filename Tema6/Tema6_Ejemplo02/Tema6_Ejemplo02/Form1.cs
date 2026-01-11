using Microsoft.VisualBasic;

namespace Tema6_Ejemplo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int Tamano = 10;

        // Declaramos y damos tamaño al vector.
        int[] vector = new int[Tamano];

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
                    MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
                }

            } while (!esCorrecto);

            return num;
        }

        void LeerVector(int[] vector)
        {
            string mensaje = "";

            // Leemos todos los elementos del vector.
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

        int SumarVector(int[] vector)
        {
            int suma = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }

            return suma;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto;

            texto = MostrarVector(vector);

            MessageBox.Show(texto);
        }

        private void btnDividirPos_Click(object sender, EventArgs e)
        {
            int posicion, suma;

            posicion = int.Parse(Interaction.InputBox("Introduce la posición a dividir."));

            if (posicion >= 0 && posicion < vector.Length)
            {
                suma = SumarVector(vector);
                MessageBox.Show($"Resultado: {suma / vector[posicion]}");
            }
            else
            {
                MessageBox.Show("La posición sale de los límites del vector.");
            }
        }
    }
}
