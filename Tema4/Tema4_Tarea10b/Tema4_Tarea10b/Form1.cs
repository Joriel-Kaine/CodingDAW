namespace Tema4_Tarea10b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int NumeroMenor (int num1, int num2)
        {
            int menor = num1;

            if (num1 > num2)
            {
                menor = num2;
            }

            return menor;
        }

        int MaximoComunDivisor (int num1, int num2)
        {
            int mcd = 0, menor = NumeroMenor(num1, num2);

            for (int i = 1; i <= menor; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    mcd = i;
                }
            }

            return mcd;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool esCorrecto1, esCorrecto2;

            esCorrecto1 = int.TryParse(txtNum1.Text, out num1);
            esCorrecto2 = int.TryParse(txtNum2.Text, out num2);

            if (esCorrecto1 && esCorrecto2)
            {
                lblResultado.Text = $"Máximo Común Divisor: {MaximoComunDivisor(num1, num2)}";
            }
            else
            {
                MessageBox.Show("Introduce valores numéricos válidos.", "Error de formato");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum1.Focus();
            lblResultado.Text = "";
        }
    }
}
