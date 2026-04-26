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


        // Método auxiliar para actualizar las listas según la categoría.
        private void ActualizarListas()
        {
            // Si el ComboBox no tiene nada seleccionado, muestra la lista entera.
            // Si no, muestra la lista según tipo de profesional.
            if (cmbCategoria.Text == "Elige una categoría")
            {
                MostrarTodosProfesionales();
            }
            else
            {
                MostrarPorProfesional();
            }
        }

        // Método auxiliar que ejecuta el método para eliminar por posicion.
        private void EliminarUsandoPosicion(int posicion)
        {
            // Muestra un mensaje emergente según si se ha eliminado correctamente o no.
            if (_listaProfesionales.EliminarProfesionalPorPosicion(posicion))
            {
                MessageBox.Show("Profesional eliminado correctamente.");
                ActualizarListas(); // Actualiza las listas según convenga.
            }
            else
            {
                MessageBox.Show("No existe el profesional a eliminar.");
            }
        }

        // Método para acceder a los formularios de los tipos de profesionales.
        private void AccederFormularios()
        {
            if (cmbCategoria.SelectedItem is null)
            {
                MessageBox.Show("Selecciona una categoría.");
            }
            else
            {
                switch (cmbCategoria.Text) // Se usa un ComboBox para la elección del tipo de profesional.
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
        }

        // Método para mostrar profesionales a través del ComboBox.
        private void MostrarPorProfesional()
        {
            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();

            if (cmbCategoria.SelectedItem is null)
            {
                MessageBox.Show("Selecciona una categoría.");
            }
            else
            {
                switch (cmbCategoria.Text) // Salen en la lista según el profesional seleccionado.
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
        }

        // Método para eliminar a un profesional por su DNI (identificador único).
        private void EliminarProfesionalesPorDNI()
        {
            string dniBox = txtEliminarProfesional.Text;
            string dni;
            bool esCorrecto = true;

            esCorrecto = FuncionesInterfaz.ValidarDNI(dniBox, out dni);

            if (_listaProfesionales.EliminarProfesionalPorDNI(dni))
            {
                MessageBox.Show("Profesional eliminado correctamente.");
                ActualizarListas();
            }
            else
            {
                MessageBox.Show("No existe el profesional a eliminar.");
            }
        }

        // Método para eliminar el profesional por la posición.
        private void EliminarProfesionalesPorPosicion()
        {
            string posicionBox = txtEliminarPosicion.Text;
            int posicion;
            bool esCorrecto = true;

            esCorrecto = FuncionesInterfaz.ValidarEntero(posicionBox, out posicion);

            // Si no es correcto sale el mensaje emergente de la validación y no sigue el método.
            if (!esCorrecto)
            {
                return;
            }

            EliminarUsandoPosicion(posicion);
        }

        // Método para eliminar el profesional seleccionándolo en la lista.
        public void EliminarProfesionalDesdeLista()
        {
            int posicion = lstProfesionales.SelectedIndex;

            EliminarUsandoPosicion(posicion);
        }

        // Método para mostrar a todos los profesionales sin importar el tipo.
        private void MostrarTodosProfesionales()
        {
            lstProfesionales.Items.Clear();
            List<Profesional> listaProfesionales = _listaProfesionales.DevolverListaProfesionales();

            foreach (Profesional profesional in listaProfesionales)
            {
                lstProfesionales.Items.Add(profesional);
            }
        }

        // Método para ordenar los profesionales según la opción del ComboBox.
        private void OrdenarProfesionales()
        {
            switch (cmbOpcion.SelectedItem?.ToString())
            {
                case "Nombre":
                    _listaProfesionales.OrdenarPor("Nombre");
                    break;
                case "DNI":
                    _listaProfesionales.OrdenarPor("DNI");
                    break;
                case "Puesto":
                    _listaProfesionales.OrdenarPor("Puesto");
                    break;
                case "Salario hora":
                    _listaProfesionales.OrdenarPor("Salario hora");
                    break;
            }

            ActualizarListas();
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

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            this.OrdenarProfesionales();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstProfesionales.Items.Clear();
            cmbCategoria.Text = "Elige una categoría";
            txtEliminarProfesional.Text = null;
            txtEliminarPosicion.Text = null;
            cmbOpcion.Text = "Elige una opción";
        }
    }
}
