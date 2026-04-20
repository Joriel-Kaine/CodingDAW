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

namespace Tema8_Tarea05_Integrador
{
    public partial class FormDesigner : Form
    {
        // Campos privados.
        private ListaProfesionales _listaProfesionales;


        // Constructor con parámetros de entrada.
        public FormDesigner(ListaProfesionales listaProfesionales)
        {
            InitializeComponent();
            this._listaProfesionales = listaProfesionales;
        }


        // Métodos.
        private void AddDesigner()
        {
            // Declaración de variables con los datos de los cuadros de texto.
            string nombreBox = txtNombre.Text,
                   dniBox = txtDNI.Text,
                   emailBox = txtEmail.Text,
                   telefonoBox = txtEmail.Text,
                   especialidadBox = txtTelefono.Text,
                   tarifaHoraBox = txtEspecialidad.Text;

            // Declaración de variables donde se guardarán los valores ya validados y convertidos.
            string nombre, dni, email, telefono, especialidad;
            double tarifaHora;

            // Declaración del booleano que comprobará que los datos son correctos.
            bool esCorrecto = true;

            // Se comprueba si los datos con correctos (con AND).
            esCorrecto &= FuncionesInterfaz.ValidarTexto(nombreBox, out nombre);
            esCorrecto &= FuncionesInterfaz.ValidarDNI(dniBox, out dni);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(emailBox, out email);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(telefonoBox, out telefono);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(especialidadBox, out especialidad);
            esCorrecto &= FuncionesInterfaz.ValidarDouble(tarifaHoraBox, out tarifaHora);

            if (esCorrecto) // Si es correcto se añade a la lista.
            {
                Designer designer = new(nombre, dni, email, telefono, especialidad, tarifaHora);

                _listaProfesionales.AddProfesional(designer);
            }
        }

        private void FormDesigner_Load(object sender, EventArgs e)
        {
            txtEspecialidad.Text = "0";
        }

        private void btnAddDesigner_Click(object sender, EventArgs e)
        {
            this.AddDesigner();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtDNI.Text = null;
            txtEmail.Text = null;
            txtTelefono.Text = null;
            txtEspecialidad.Text = "0";
            txtNombre.Focus();
        }
    }
}
