using Tema8_Tarea03.Interfaz;
using Tema8_Tarea03.Modelos;

namespace Tema8_Tarea03
{
    public partial class FormFiguras : Form
    {
        private List<Figura> _listaFiguras = new();

        public FormFiguras()
        {
            InitializeComponent();
        }

        private void btnCrearCirculo_Click(object sender, EventArgs e)
        {
            FormCirculos formCirculos = new(_listaFiguras);

            formCirculos.ShowDialog();
        }

        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            FormCuadrados formCuadrados = new(_listaFiguras);

            formCuadrados.ShowDialog();
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            FuncionesInterfazFiguras.MostrarTodasFiguras(_listaFiguras);
        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            FuncionesInterfazFiguras.MostrarCirculos(_listaFiguras);
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            FuncionesInterfazFiguras.MostrarCuadrados(_listaFiguras);
        }
    }
}
