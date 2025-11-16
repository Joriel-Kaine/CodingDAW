namespace Tema4_Tarea10b
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
            
            esCorrecto = int.TryParse(mensaje, out num);

            if (!esCorrecto)   
            {
                MessageBox.Show("Introduce un valor numérico válido.", "Error de formato");
            }
            
            return num;
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
            int mcd = 0;

            for (int i = 1; i <= NumeroMenor(num1, num2); i++)
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

            num1 = LeerNumero(txtNum1.Text);
            num2 = LeerNumero(txtNum2.Text);

            lblResultado.Text = $"MCD: {MaximoComunDivisor(num1, num2)}";
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
