using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea05_Integrador.Interfaz;
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


        // Método para actualizar el ComboBox de profesionales y proyectos con los datos existentes.
        private void ActualizarComboList()
        {
            cmbProfesionales.Items.Clear();
            cmbProyectos.Items.Clear();

            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();
            List<Proyecto> listaProyectos = _listaProyectos.DevolverListaProyectos();

            // Usamos foreach para añadir a los ComboBox todos los datos.
            foreach (Profesional profesional in listaProfesionales)
            {
                cmbProfesionales.Items.Add(profesional.ComboBoxProfesional);
            }

            foreach (Proyecto proyecto in listaProyectos)
            {
                cmbProyectos.Items.Add(proyecto.ComboBoxProyecto);
            }
        }

        // Método para mostrar todos los proyectos.
        private void MostrarTodosProyectos()
        {
            lstProyectos.Items.Clear();
            List<Proyecto> listaProyectos = _listaProyectos.DevolverListaProyectos();

            foreach (Proyecto proyecto in listaProyectos)
            {
                lstProyectos.Items.Add(proyecto);
            }
        }

        // Método para acceder al formulario para añadir un proyecto.
        private void AccederFormulario()
        {
            FormProyecto formProyecto = new(_listaProyectos);

            formProyecto.ShowDialog();
        }

        // Método para asignar un profesional a un proyecto.
        private void AsignarProfesionalProyecto()
        {
            // Comprobación de si no hay seleccionado nada en los ComboBox con mensaje emergente.
            if (cmbProfesionales.SelectedItem == null || cmbProyectos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un profesional y un proyecto.");
            }
            else
            {
                // Se obtiene el texto seleccionado en los ComboBox.
                // Son los strings formados en la clase Profesional, pero no los objetos en sí.
                string? comboProfesional = cmbProfesionales.SelectedItem.ToString();
                string? comboProyecto = cmbProyectos.SelectedItem.ToString();

                // Buscamos el objeto real a través de esa selección del ComboBox usando LINQ.
                // Se declara un profesional y se llama a una función en ListaProfesionales.
                // Con FirstOrDefault se busca el primer elemento de la lista que cumpla una condición.
                // La condición se representa mediante una función anónima (lambda) para recuperar el objeto.
                Profesional? profesional = _listaProfesionales
                    .DevolverListaProfesionales()
                    .FirstOrDefault(profesional => profesional.ComboBoxProfesional == comboProfesional);
                // Lo mismo con Proyecto.
                Proyecto? proyecto = _listaProyectos
                    .DevolverListaProyectos()
                    .FirstOrDefault(proyecto => proyecto.ComboBoxProyecto == comboProyecto);

                // Si el profesional o el proyecto es nulo, mostramos mensaje emergente.
                if (profesional is null || proyecto is null)
                {
                    MessageBox.Show("Error interno.");
                }
                else
                {
                    // Si no lo es, declaramos una variable donde se crea el proyecto o profesional en las listas.
                    bool isAddProyecto = profesional.AddProyecto(proyecto);
                    bool isAddProfesional = proyecto.AddProfesional(profesional);

                    // Se comprueba con una condición si el se puede o no asignar el profesional al proyecto.
                    if (isAddProyecto && isAddProfesional)
                    {
                        MessageBox.Show("Profesional asignado.");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el profesional en ese proyecto");
                    }
                }
            }
        }

        // Método para mostrar los particpantes que hay en un proyecto.
        private void MostrarParticipantesProyecto()
        {
            if (cmbProyectos.SelectedItem == null)
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
                    return;
                }
                else
                {
                    lstProyectos.Items.Clear();
                    List<Profesional> listaProfesionalesProyecto = proyecto.DevolverListaProfesionalesProyecto();

                    foreach (Profesional profesional in listaProfesionalesProyecto)
                    {
                        lstProyectos.Items.Add(profesional);
                    }

                    if (lstProyectos.Items.Count == 0)
                    {
                        MessageBox.Show("No hay participantes para este proyecto.");
                    }
                }
            }
        }

        // Método para eliminar proyectos por código.
        private void EliminarProyectosPorCodigo()
        {
            string codigoBox = txtEliminarProyecto.Text;
            int codigo;
            bool esCorrecto = true;

            esCorrecto = FuncionesInterfaz.ValidarCodigo(codigoBox, out codigo);

            if (!esCorrecto)
            {
                return;
            }

            if (_listaProyectos.EliminarProyectoPorCodigo(codigo))
            {
                MessageBox.Show("Proyecto eliminado correctamente.");
                MostrarTodosProyectos();
            }
            else
            {
                MessageBox.Show("No existe el proyecto a eliminar.");
            }
        }

        // Método para eliminar proyectos desde la lista.
        private void EliminarProyectosDesdeLista()
        {
            int posicion = lstProyectos.SelectedIndex;

            if (_listaProyectos.EliminarProyectosPorPosicion(posicion))
            {
                MessageBox.Show("Proyecto eliminado correctamente.");
                MostrarTodosProyectos();
            }
            else if (lstProyectos.Items.Count == 0)
            {
                MessageBox.Show("La lista está vacía.");
            }
            else
            {
                MessageBox.Show("Selecciona un proyecto a eliminar.");
            }
        }

        // Método para mostrar los proyectos que no tienen profesionales asignados.
        private void ProyectosSinProfesional()
        {
            lstProyectos.Items.Clear();
            List<Proyecto> listaProyectos = _listaProyectos.DevolverListaProyectos();

            foreach (Proyecto proyecto in listaProyectos)
            {
                if (proyecto.DevolverListaProfesionalesProyecto().Count <= 0)
                {
                    lstProyectos.Items.Add(proyecto);
                }
            }
        }


        // Load del formulario.
        private void FormProyectos_Load(object sender, EventArgs e)
        {
            this.ActualizarComboList();
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
            this.AsignarProfesionalProyecto();
        }

        private void btnVerParticipantesProyecto_Click(object sender, EventArgs e)
        {
            this.MostrarParticipantesProyecto();
        }

        private void btnEliminarPorCodigo_Click(object sender, EventArgs e)
        {
            this.EliminarProyectosPorCodigo();
        }

        private void btnEliminarDesdeLista_Click(object sender, EventArgs e)
        {
            this.EliminarProyectosDesdeLista();
        }

        private void btnProyectosSinProfesionales_Click(object sender, EventArgs e)
        {
            this.ProyectosSinProfesional();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProyectos.Items.Clear();
            cmbProfesionales.Text = "Elige un profesional";
            cmbProyectos.Text = "Elige un proyecto";
            txtEliminarProyecto = null;
        }

        
    }
}
