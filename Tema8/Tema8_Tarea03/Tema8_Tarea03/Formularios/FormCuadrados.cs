using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea03.Interfaz;
using Tema8_Tarea03.Modelos;

namespace Tema8_Tarea03
{
    public partial class FormCuadrados : Form
    {
        private List<Figura> _listaFiguras;

        public FormCuadrados(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this._listaFiguras = listaFiguras;
        }

        private void btnAddCuadrado_Click(object sender, EventArgs e)
        {
            // Se leen los cuadros de texto del formulario.
            string posXBox = txtPosX.Text,
                   posYBox = txtPosY.Text,
                   colorBox = txtColor.Text,
                   ladoBox = txtLado.Text;

            // Se validan los valores introducidos en los cuadros de texto.
            int posX, posY, lado;
            string color;
            bool esCorrecto = true;

            // Se comprueba (con un AND) si esCorrecto o no esCorrecto.
            esCorrecto &= FuncionesInterfaz.ValidarEntero(posXBox, out posX);
            esCorrecto &= FuncionesInterfaz.ValidarEntero(posYBox, out posY);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(colorBox, out color);
            esCorrecto &= FuncionesInterfaz.ValidarEntero(ladoBox, out lado);

            if (esCorrecto)
            {
                FuncionesInterfazFiguras.CrearCuadrado(_listaFiguras, posX, posY, color, lado);
            }
        }

        private void FormCuadrados_Load(object sender, EventArgs e)
        {
            txtPosX.Text = "0";
            txtPosY.Text = "0";
            txtLado.Text = "0";
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
