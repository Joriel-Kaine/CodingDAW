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
            FuncionesInterfazFigura.CrearCirculo(_listaFiguras);
        }

        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            FuncionesInterfazFigura.CrearCuadrado(_listaFiguras);
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            FuncionesInterfazFigura.MostrarTodasFiguras(_listaFiguras);
        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            FuncionesInterfazFigura.MostrarCirculos(_listaFiguras);
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            FuncionesInterfazFigura.MostrarCuadrados(_listaFiguras);
        }
    }
}
