namespace Tema4_Tarea07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void DevolverOperaciones (int num1, int num2, out int suma,
                                    out int resta, out int producto)
        {
            suma = num1 + num2;
            resta = num1 - num2;
            producto = num1 * num2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool esCorrecto1, esCorrecto2;
            int num1, num2, suma, resta, producto;

            esCorrecto1 = int.TryParse(txtNum1.Text, out num1);
            esCorrecto2 = int.TryParse(txtNum2.Text, out num2);

            if (esCorrecto1 && esCorrecto2)
            {
                DevolverOperaciones(num1, num2, out suma, out resta, out producto);
                lblResultado.Text = $"Suma: {suma}\n\nResta: {resta}\n\nProducto: {producto}";
            }
            else
            {
                MessageBox.Show("Introduce valores numéricos.", "Error de formato");
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
