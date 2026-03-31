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
    public partial class FormCirculos : Form
    {
        private List<Figura> _listaFiguras;

        public FormCirculos(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this._listaFiguras = listaFiguras;
        }

        private void btnAddCirculo_Click(object sender, EventArgs e)
        {
            // Se leen los cuadros de texto del formulario.
            string posXBox = txtPosX.Text,
                   posYBox = txtPosY.Text,
                   colorBox = txtColor.Text,
                   RadioBox = txtRadio.Text;

            // Se validan los valores introducidos en los cuadros de texto.
            int posX, posY, radio;
            string color;
            bool esCorrecto = true;

            // Se comprueba (con un AND) si esCorrecto o no esCorrecto.
            esCorrecto &= FuncionesInterfaz.ValidarEntero(posXBox, out posX);
            esCorrecto &= FuncionesInterfaz.ValidarEntero(posYBox, out posY);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(colorBox, out color);
            esCorrecto &= FuncionesInterfaz.ValidarEntero(RadioBox, out radio);

            if (esCorrecto)
            {
                FuncionesInterfazFiguras.CrearCirculo(_listaFiguras, posX, posY, color, radio);
            }
        }

        private void FormCirculos_Load(object sender, EventArgs e)
        {
            txtPosX.Text = "0";
            txtPosY.Text = "0";
            txtRadio.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPosX.Text = "0";
            txtPosY.Text = "0";
            txtColor.Text = null;
            txtRadio.Text = "0";
            txtPosX.Focus();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
