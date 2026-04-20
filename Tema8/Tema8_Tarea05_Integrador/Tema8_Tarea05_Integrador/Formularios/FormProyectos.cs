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
    public partial class FormProyectos : Form
    {
        private ListaProyectos _listaProyectos;
        private ListaProfesionales _listaProfesionales;

        public FormProyectos(ListaProyectos listaProyectos, ListaProfesionales listaProfesionales)
        {
            InitializeComponent();
            this._listaProyectos = listaProyectos;
            this._listaProfesionales = listaProfesionales;
        }

        // Métodos.
        private void ActualizarComboLists()
        {
            cmbProfesionales.Items.Clear();
            cmbProyectos.Items.Clear();

            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();
            List<Proyecto> listaProyectos = _listaProyectos.DevolverListaProyectos();

            foreach (Profesional profesional in listaProfesionales)
            {
                cmbProfesionales.Items.Add(profesional.ComboBoxProfesional);
            }

            foreach (Proyecto proyecto in listaProyectos)
            {
                cmbProyectos.Items.Add(proyecto.ComboBoxProyecto);
            }
        }

        private void MostrarTodosProyectos()
        {
            lstProyectos.Items.Clear();
            List<Proyecto> listaProyectos = _listaProyectos.DevolverListaProyectos();

            foreach (Proyecto proyecto in listaProyectos)
            {
                lstProyectos.Items.Add(proyecto);
            }
        }

        private void AccederFormulario()
        {
            FormProyecto formProyecto = new(_listaProyectos);

            formProyecto.ShowDialog();
        }

        private void AsignarProfesionalProyecto()
        {
            if (cmbProfesionales.SelectedItem == null || cmbProyectos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un profesional y un proyecto.");
            }
            else
            {
                string? comboProfesional = cmbProfesionales.SelectedItem.ToString();
                string? comboProyecto = cmbProyectos.SelectedItem.ToString();

                Profesional? profesional = _listaProfesionales
                    .DevolverListaProfesionales()
                    .FirstOrDefault(profesional => profesional.ComboBoxProfesional == comboProfesional);
                Proyecto? proyecto = _listaProyectos
                    .DevolverListaProyectos()
                    .FirstOrDefault(proyecto => proyecto.ComboBoxProyecto == comboProyecto);
                
                if (profesional is null || proyecto is null)
                {
                    MessageBox.Show("Error.");
                }
                else
                {
                    profesional.AddProyecto(proyecto);
                    proyecto.AddProfesional(profesional);

                    MessageBox.Show("Profesional asignado.");
                }
            }
        }


        // Load del formulario.
        private void FormProyectos_Load(object sender, EventArgs e)
        {
            this.ActualizarComboLists();
        }


        // Botones.
        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            this.AccederFormulario();
        }

        private void btnListaProyectos_Click(object sender, EventArgs e)
        {
            this.MostrarTodosProyectos();
        }

        private void btnAsignarProfesionalProyecto_Click(object sender, EventArgs e)
        {

        }

        private void btnVerParticipantesProyecto_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProyectos.Items.Clear();
        }
    }
}
