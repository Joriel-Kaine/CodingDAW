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

        }

        private void FormCirculos_Load(object sender, EventArgs e)
        {
            txtPosX.Text = "0";
            txtPosY.Text = "0";
            txtRadio.Text = "0";
        }
    }
}
