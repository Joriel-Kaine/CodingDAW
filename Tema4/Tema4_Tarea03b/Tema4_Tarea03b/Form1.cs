namespace Tema4_Tarea03b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MayorDosNumeros(int num1, int num2)
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
            bool esCorrecto1, esCorrecto2;
            int num1, num2, mayor;

            esCorrecto1 = int.TryParse(txtNum1.Text, out num1);
            esCorrecto2 = int.TryParse(txtNum2.Text, out num2);

            if (!esCorrecto1 || !esCorrecto2)
            {
                MessageBox.Show("Debes introducir valores numéricos.");
            }
            else
            {
                mayor = MayorDosNumeros(num1, num2);

                lblResultado.Text = $"El número mayor es: {mayor}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Focus();
            lblResultado.Text = "";
        }
    }
}
