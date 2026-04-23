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
        private void ActualizarComboList()
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

        private void MostrarTodo()
        {
            lstAnalisis.Items.Clear();

            var totalProfesionales = _listaProfesionales.DevolverListaProfesionales().Count;
            var totalProyectos = _listaProyectos.DevolverListaProyectos().Count;

            lstAnalisis.Items.Add($"El total de profesionales que hay es de {totalProfesionales}");
            lstAnalisis.Items.Add($"El total de proyectos que hay es de {totalProyectos}");
        }

        private void CosteTotalProyecto()
        {
            if (cmbProyectos.SelectedItem is null)
            {
                MessageBox.Show("Selecciona un proyecto.");
            }
            else
            {
                string? comboProyecto = cmbProyectos.SelectedItem.ToString();

                Proyecto? proyecto = _listaProyectos
                    .DevolverListaProyectos()
                    .FirstOrDefault(proyecto => proyecto.ComboBoxProyecto == comboProyecto);

                if (proyecto is null)
                {
                    MessageBox.Show("Error.");
                }
                else
                {
                    lstAnalisis.Items.Clear();
                    List<Profesional> listaProfesionalesProyecto = proyecto.DevolverListaProfesionalesProyecto();
                    double totalTarifaHora = 0;

                    foreach (Profesional profesional in listaProfesionalesProyecto)
                    {
                        totalTarifaHora += profesional.CalcularPresupuesto();
                    }

                    lstAnalisis.Items.Add($"El total del coste del proyecto es de " +
                                          $"{totalTarifaHora * proyecto.Duracion:C2}");
                }
            }
        }

        private void ProyectosDeProfesional()
        {
            if (cmbProfesionales.SelectedItem is null)
            {
                MessageBox.Show("Selecciona un profesional.");
            }
            else
            {
                string? comboProfesional = cmbProfesionales.SelectedItem.ToString();

                Profesional? profesional = _listaProfesionales
                    .DevolverListaProfesionales()
                    .FirstOrDefault(profesional => profesional.ComboBoxProfesional == comboProfesional);

                if (profesional is null)
                {
                    MessageBox.Show("Error.");
                }
                else
                {
                    lstAnalisis.Items.Clear();
                    List<Proyecto> listaProyectosProfesional = profesional.DevolverListaProyectosProfesional();

                    foreach (Proyecto proyecto in listaProyectosProfesional)
                    {
                        lstAnalisis.Items.Add(proyecto);
                    }
                }
            }
        }

        private void GananciasProfesional()
        {
            if (cmbProfesionales.SelectedItem is null)
            {
                MessageBox.Show("Selecciona un profesional.");
            }
            else
            {
                string? comboProfesional = cmbProfesionales.SelectedItem.ToString();

                Profesional? profesional = _listaProfesionales
                    .DevolverListaProfesionales()
                    .FirstOrDefault(profesional => profesional.ComboBoxProfesional == comboProfesional);

                if (profesional is null)
                {
                    MessageBox.Show("Error.");
                }
                else
                {
                    lstAnalisis.Items.Clear();
                    List<Proyecto> listaProyectosProfesional = profesional.DevolverListaProyectosProfesional();
                    double totalHoras = 0;

                    foreach (Proyecto proyecto in listaProyectosProfesional)
                    {
                        totalHoras += proyecto.Duracion;
                    }

                    lstAnalisis.Items.Add($"El total de ganancias del profesional es de " +
                                          $"{totalHoras * profesional.CalcularPresupuesto():C2}");
                }
            }
        }


        // Load del formulario.
        private void FormAnalisis_Load(object sender, EventArgs e)
        {
            this.ActualizarComboList();
        }


        // Botones.
        private void btnTotalProfesionalesProyectos_Click(object sender, EventArgs e)
        {
            this.MostrarTodo();
        }

        private void btnTotalCosteProyecto_Click(object sender, EventArgs e)
        {
            this.CosteTotalProyecto();
        }

        private void btnProyectosProfesional_Click(object sender, EventArgs e)
        {
            this.ProyectosDeProfesional();
        }

        private void btnTotalGananciasProfesional_Click(object sender, EventArgs e)
        {
            this.GananciasProfesional();
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
