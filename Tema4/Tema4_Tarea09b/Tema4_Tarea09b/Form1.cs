using Microsoft.VisualBasic;

namespace Tema4_Tarea09b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int LeerNumero (string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                mensaje = Interaction.InputBox("Introduce un número entero", "Número entero", "numero");

                esCorrecto = int.TryParse(mensaje, out num);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce un valor numérico válido.", "Error de formato");
                }

            } while (!esCorrecto);

            return num;
        }

        private void btnLeerNum_Click(object sender, EventArgs e)
        {
            int num;
            string mensaje = "";

            num = LeerNumero(mensaje);
        }
    }
}
