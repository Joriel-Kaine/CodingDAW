using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea05_Integrador.Interfaz;
using Tema8_Tarea05_Integrador.Profesionales;

namespace Tema8_Tarea05_Integrador
{
    public partial class FormProfesionales : Form
    {
        private ListaProfesionales _listaProfesionales;

        public FormProfesionales(ListaProfesionales listaProfesionales)
        {
            InitializeComponent();
            this._listaProfesionales = listaProfesionales;
        }


        // Métodos.
        private void AccederFormularios()
        {
            switch (cmbProfesional.Text)
            {
                case "Diseñador":
                    FormDesigner formDesigner = new(_listaProfesionales);

                    formDesigner.ShowDialog();
                    break;
                case "Desarrollador":
                    FormDesarrollador formDesarrollador = new(_listaProfesionales);

                    formDesarrollador.ShowDialog();
                    break;
                case "Redactor":
                    FormRedactor formRedactor = new(_listaProfesionales);

                    formRedactor.ShowDialog();
                    break;
            }
        }

        private void MostrarPorProfesional()
        {
            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();

            switch (cmbProfesional.Text)
            {
                case "Diseñador":
                    lstProfesionales.Items.Clear();

                    foreach (Profesional profesional in listaProfesionales)
                    {
                        if (profesional is Designer designer)
                        {
                            lstProfesionales.Items.Add(profesional);
                        }
                    }
                    break;
                case "Desarrollador":
                    lstProfesionales.Items.Clear();

                    foreach (Profesional profesional in listaProfesionales)
                    {
                        if (profesional is Desarrollador desarrollador)
                        {
                            lstProfesionales.Items.Add(profesional);
                        }
                    }
                    break;
                case "Redactor":
                    lstProfesionales.Items.Clear();

                    foreach (Profesional profesional in listaProfesionales)
                    {
                        if (profesional is Redactor redactor)
                        {
                            lstProfesionales.Items.Add(profesional);
                        }
                    }
                    break;
            }
        }

        private void EliminarProfesionalesPorDNI()
        {
            string dniBox = txtEliminarProfesional.Text;
            string dni;
            bool esCorrecto = true;

            esCorrecto = FuncionesInterfaz.ValidarDNI(dniBox, out dni);

            if (_listaProfesionales.EliminarProfesionalPorDNI(dni))
            {
                MessageBox.Show("Profesional eliminado correctamente.");
                if (cmbProfesional.Text == "Elige una categoría")
                {
                    MostrarTodosProfesionales();
                }
                else
                {
                    MostrarPorProfesional();
                }
            }
            else
            {
                MessageBox.Show("No existe el profesional a eliminar.");
            }
        }

        private void EliminarProfesionalesPorPosicion()
        {
            string dniBox = txtEliminarProfesional.Text;
            string dni;
            bool esCorrecto = true;

            esCorrecto = FuncionesInterfaz.ValidarDNI(dniBox, out dni);

            int posicion = _listaProfesionales.BuscarProfesional(dni);

            if (_listaProfesionales.EliminarProfesionalPorPosicion(posicion))
            {
                MessageBox.Show("Profesional eliminado correctamente.");
                if (cmbProfesional.Text == "Elige una categoría")
                {
                    MostrarTodosProfesionales();
                }
                else
                {
                    MostrarPorProfesional();
                }
            }
            else
            {
                MessageBox.Show("No existe el profesional a eliminar.");
            }
        }

        public void EliminarProfesionalDesdeLista()
        {
            int posicion = lstProfesionales.SelectedIndex;

            if (_listaProfesionales.EliminarProfesionalPorPosicion(posicion))
            {
                MessageBox.Show("Profesional eliminado correctamente.");
                if (cmbProfesional.Text == "Elige una categoría")
                {
                    MostrarTodosProfesionales();
                }
                else
                {
                    MostrarPorProfesional();
                }
            }
            else
            {
                MessageBox.Show("No existe el profesional a eliminar.");
            }
        }

        private void MostrarTodosProfesionales()
        {
            lstProfesionales.Items.Clear();
            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();

            foreach (Profesional profesional in listaProfesionales)
            {
                lstProfesionales.Items.Add(profesional);
            }
        }


        // Load del formulario.
        private void FormProfesionales_Load(object sender, EventArgs e)
        {

        }


        // Botones.
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            this.AccederFormularios();
        }

        private void btnMostrarProfesional_Click(object sender, EventArgs e)
        {
            this.MostrarPorProfesional();
        }

        private void btnEliminarPorDNI_Click(object sender, EventArgs e)
        {
            this.EliminarProfesionalesPorDNI();
        }

        private void btnEliminarPosicion_Click(object sender, EventArgs e)
        {
            this.EliminarProfesionalesPorPosicion();
        }

        private void btnEliminarProfesionalLista_Click(object sender, EventArgs e)
        {
            this.EliminarProfesionalDesdeLista();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            this.MostrarTodosProfesionales();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProfesionales.Items.Clear();
        }
    }
}
