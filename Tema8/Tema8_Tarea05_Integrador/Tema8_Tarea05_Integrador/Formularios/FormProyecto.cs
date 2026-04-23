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
    public partial class FormProyecto : Form
    {
        private ListaProyectos _listaProyectos;

        public FormProyecto(ListaProyectos listaProyectos)
        {
            InitializeComponent();
            this._listaProyectos = listaProyectos;
        }


        // Método.
        private void AddProyectoForm()
        {
            // Declaración de variables con los datos de los cuadros de texto.
            string nombreBox = txtNombre.Text,
                   codigoBox = txtCodigo.Text,
                   duracionBox = txtDuracion.Text;

            // Declaración de variables donde se guardarán los valores ya validados y convertidos.
            string nombre;
            int codigo, duracion;

            // Declaración del booleano que comprobará que los datos son correctos.
            bool esCorrecto = true;

            // Se comprueba si los datos con correctos (con AND).
            esCorrecto &= FuncionesInterfaz.ValidarNombre(nombreBox, out nombre);
            esCorrecto &= FuncionesInterfaz.ValidarCodigo(codigoBox, out codigo);
            esCorrecto &= FuncionesInterfaz.ValidarDuracion(duracionBox, out duracion);

            if (esCorrecto) // Si es correcto se añade a la lista.
            {
                Proyecto proyecto = new(nombre, codigo, duracion);

                _listaProyectos.AddProyecto(proyecto);

                MessageBox.Show("Proyecto añadido correctamente.");
            }
        }


        // Load del formulario.
        private void FormProyecto_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "0";
            txtDuracion.Text = "0";
        }


        // Botones.
        private void btnAddProyecto_Click(object sender, EventArgs e)
        {
            this.AddProyectoForm();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtCodigo.Text = "0";
            txtDuracion.Text = "0";
        }
    }
}
