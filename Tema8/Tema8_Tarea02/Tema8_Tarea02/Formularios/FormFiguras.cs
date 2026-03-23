using Tema8_Tarea02.Base.Figuras;
using Tema8_Tarea02.Interfaz;
using Tema8_Tarea02.Listas;

namespace Tema8_Tarea02
{
    public partial class FormFiguras : Form
    {
        private ListaFiguras _listaFiguras = new();

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
