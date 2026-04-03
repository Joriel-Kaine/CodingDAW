using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea04.Interfaz;
using Tema8_Tarea04.Modelos;

namespace Tema8_Tarea04
{
    public partial class FormTriangulos : Form
    {
        private List<Figura> _listaFiguras;

        public FormTriangulos(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this._listaFiguras = listaFiguras;
        }


        // Métodos.
        private void CrearTriangulo()
        {
            // Declaración de variables con los datos de los cuadros de texto.
            string posXBox = txtPosX.Text,
                   posYBox = txtPosY.Text,
                   colorBox = txtColor.Text,
                   ladoBox = txtLado.Text;

            // Declaración de variables donde se guardarán los valores ya validados y convertidos.
            int posX, posY, lado;
            string color;

            // Declaración del booleano que comprobará que los datos son válidos.
            bool esCorrecto = true;

            // Se comprueba (con un AND) si esCorrecto o no esCorrecto.
            esCorrecto &= FuncionesInterfaz.ValidarEntero(posXBox, out posX);
            esCorrecto &= FuncionesInterfaz.ValidarEntero(posYBox, out posY);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(colorBox, out color);
            esCorrecto &= FuncionesInterfaz.ValidarEntero(ladoBox, out lado);

            if (esCorrecto)
            {
                Triangulo triangulo = new(posX, posY, color, lado);
                _listaFiguras.Add(triangulo);
            }
        }


        // Botones.
        private void FormTriangulos_Load(object sender, EventArgs e)
        {
            txtPosX.Text = "0";
            txtPosY.Text = "0";
            txtLado.Text = "0";
        }

        private void btnAddTriangulo_Click(object sender, EventArgs e)
        {
            this.CrearTriangulo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPosX.Text = "0";
            txtPosY.Text = "0";
            txtColor.Text = null;
            txtLado.Text = "0";
            txtPosX.Focus();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
