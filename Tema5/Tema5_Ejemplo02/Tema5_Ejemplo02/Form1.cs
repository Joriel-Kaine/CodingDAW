namespace Tema5_Ejemplo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMCD_Click(object sender, EventArgs e)
        {
            int n1, n2, mcd;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            // Llamamos a la función
            mcd = Funciones.CalcularMCD(n1, n2);

            MessageBox.Show($"El MCD es: {mcd}", "Máximo Común Divisor");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            int bbase, exponente, potencia;

            bbase = int.Parse(txtN1.Text);
            exponente = int.Parse(txtN2.Text);

            potencia = Funciones.Potencia(bbase, exponente);

            MessageBox.Show($"La potencia es: {potencia}", "Potencia");
        }
    }
}
