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
            string posX = txtPosX.Text,
                   posY = txtPosY.Text,
                   color = txtColor.Text,
                   lado = txtLado.Text;


        }
    }
}
