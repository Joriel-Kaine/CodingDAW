using Tema8_Tarea02.Base.Figuras;

namespace Tema8_Tarea02
{
    public partial class FormFiguras : Form
    {
        public FormFiguras()
        {
            InitializeComponent();
        }

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new(10, 20, "Azul", 5);

            MessageBox.Show(circulo.QuienSoy());
            MessageBox.Show(circulo.ToString());
            MessageBox.Show($"El área es: {circulo.Area()}");
        }

        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado cuadrado = new(20, 40, "Rojo", 10);

            MessageBox.Show(cuadrado.QuienSoy());
            MessageBox.Show(cuadrado.ToString());
            MessageBox.Show($"El área es: {cuadrado.Area()}");
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {

        }
    }
}
