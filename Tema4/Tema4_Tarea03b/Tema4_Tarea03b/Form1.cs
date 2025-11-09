namespace Tema4_Tarea03b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MayorDosNumeros (int num1, int num2)
        {
            int mayor = num1;

            if (num1 < num2)
            {
                mayor = num2;
            }

            return mayor;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
