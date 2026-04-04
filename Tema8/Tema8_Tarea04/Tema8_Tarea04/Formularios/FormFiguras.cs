using Tema8_Tarea04.Interfaz;
using Tema8_Tarea04.Modelos;

namespace Tema8_Tarea04
{
    public partial class FormFiguras : Form
    {
        private List<Figura> _listaFiguras = new();

        public FormFiguras()
        {
            InitializeComponent();
        }


        // Métodos.
        private void Autorrelleno()
        {
            _listaFiguras.Add(new Circulo(28, 16, "Amarillo", 8));
            _listaFiguras.Add(new Cuadrado(85, 25, "Magenta", 12));
            _listaFiguras.Add(new Cuadrado(44, 23, "Azul", 6));
            _listaFiguras.Add(new Triangulo(23, 8, "Marrón", 4));
            _listaFiguras.Add(new Circulo(62, 39, "Negro", 20));
            _listaFiguras.Add(new Circulo(58, 22, "Lila", 16));
            _listaFiguras.Add(new Rectangulo(48, 20, "Celeste", 24, 14));
            _listaFiguras.Add(new Rectangulo(82, 47, "Rosa", 46, 31));
            _listaFiguras.Add(new Cuadrado(70, 60, "Verde", 55));
            _listaFiguras.Add(new Triangulo(69, 40, "Lima", 38));
            _listaFiguras.Add(new Triangulo(74, 68, "Rojo", 43));
            _listaFiguras.Add(new Rectangulo(72, 64, "Violeta", 53, 37));
        }

        private void MostrarFiguras()
        {
            lstBoxFiguras.Items.Clear();

            foreach (Figura figura in _listaFiguras)
            {
                lstBoxFiguras.Items.Add(figura);
            }
        }

        private void MostrarCirculos()
        {
            lstBoxFiguras.Items.Clear();

            foreach (Figura figura in _listaFiguras)
            {
                if (figura is Circulo circulo)
                {
                    lstBoxFiguras.Items.Add(figura);
                }
            }
        }

        private void MostrarCuadrados()
        {
            lstBoxFiguras.Items.Clear();

            foreach (Figura figura in _listaFiguras)
            {
                if (figura is Cuadrado cuadradado)
                {
                    lstBoxFiguras.Items.Add(figura);
                }
            }
        }

        private void MostrarTriangulos()
        {
            lstBoxFiguras.Items.Clear();

            foreach (Figura figura in _listaFiguras)
            {
                if (figura is Triangulo triangulo)
                {
                    lstBoxFiguras.Items.Add(figura);
                }
            }
        }

        private void MostrarRectangulos()
        {
            lstBoxFiguras.Items.Clear();

            foreach (Figura figura in _listaFiguras)
            {
                if (figura is Rectangulo rectangulo)
                {
                    lstBoxFiguras.Items.Add(figura);
                }
            }
        }

        private Figura DevolverFiguraPorPosicion(int posicion)
        {
            return _listaFiguras[posicion];
        }

        private void MostrarFigura()
        {
            int posicion = lstBoxFiguras.SelectedIndex;

            if (posicion >= 0)
            {
                Figura figura = DevolverFiguraPorPosicion(posicion);

                MessageBox.Show(figura.GenerarTextoFigura());
            }
        }

        private void EliminarFigura()
        {
            int posicion = lstBoxFiguras.SelectedIndex;

            if (posicion >= 0)
            {
                _listaFiguras.RemoveAt(posicion);
            }
        }


        // Botones.
        private void btnAutorrelleno_Click(object sender, EventArgs e)
        {
            this.Autorrelleno();
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

        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulos formTriangulos = new(_listaFiguras);

            formTriangulos.ShowDialog();
        }

        private void btnCrearRectangulo_Click(object sender, EventArgs e)
        {
            FormRectangulos formRectangulos = new(_listaFiguras);

            formRectangulos.ShowDialog();
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            this.MostrarFiguras();
        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            this.MostrarCirculos();
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            this.MostrarCuadrados();
        }

        private void btnMostrarTriangulos_Click(object sender, EventArgs e)
        {
            this.MostrarTriangulos();
        }

        private void btnMostrarRectangulos_Click(object sender, EventArgs e)
        {
            this.MostrarRectangulos();
        }

        private void btnMostrarFigura_Click(object sender, EventArgs e)
        {
            this.MostrarFigura();
        }

        private void btnEliminarFigura_Click(object sender, EventArgs e)
        {
            this.EliminarFigura();
            this.MostrarFiguras();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
