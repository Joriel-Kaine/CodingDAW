using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea05_Integrador.Profesionales;
using Tema8_Tarea05_Integrador.Proyectos;

namespace Tema8_Tarea05_Integrador
{
    public partial class FormAnalisis : Form
    {
        private ListaProyectos _listaProyectos;
        private ListaProfesionales _listaProfesionales;

        public FormAnalisis(ListaProyectos listaProyectos, ListaProfesionales listaProfesionales)
        {
            InitializeComponent();
            this._listaProyectos = listaProyectos;
            this._listaProfesionales = listaProfesionales;
        }


        // Métodos.
        private void MostrarTodo()
        {
            lstAnalisis.Items.Clear();

            var totalProfesionales = _listaProfesionales.DevolverListaProfesionales().Count;
            var totalProyectos = _listaProyectos.DevolverListaProyectos().Count;

            lstAnalisis.Items.Add($"El total de profesionales que hay es de {totalProfesionales}");
            lstAnalisis.Items.Add($"El total de proyectos que hay es de {totalProyectos}");
        }


        // Load del formulario.
        private void FormAnalisis_Load(object sender, EventArgs e)
        {

        }


        // Botones.
        private void btnTotalProfesionalesProyectos_Click(object sender, EventArgs e)
        {
            this.MostrarTodo();
        }

        private void btnTotalCosteProyecto_Click(object sender, EventArgs e)
        {

        }

        private void btnProyectosProfesional_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalGananciasProfesional_Click(object sender, EventArgs e)
        {

        }

        private void btnProfesionalesEnProyectos_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstAnalisis.Items.Clear();
            cmbProfesionales.Text = null;
        }
    }
}
