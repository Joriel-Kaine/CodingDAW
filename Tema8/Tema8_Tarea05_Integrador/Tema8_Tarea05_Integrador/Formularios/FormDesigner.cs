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
                   telefonoBox = txtTelefono.Text,
                   especialidadBox = txtEspecialidad.Text,
                   tarifaHoraBox = txtTarifaHora.Text;

            // Declaración de variables donde se guardarán los valores ya validados y convertidos.
            string nombre, dni, email, telefono, especialidad, telefonoCompleto;
            double tarifaHora;

            // Declaración del booleano que comprobará que los datos son correctos.
            bool esCorrecto = true;

            // Se comprueba si los datos con correctos (con AND).
            // Si no son correctos, lanzan mensajes de error en cada caso.
            esCorrecto &= FuncionesInterfaz.ValidarNombre(nombreBox, out nombre);
            esCorrecto &= FuncionesInterfaz.ValidarDNI(dniBox, out dni);
            esCorrecto &= FuncionesInterfaz.ValidarEmail(emailBox, out email);
            esCorrecto &= FuncionesInterfaz.ValidarTelefono(cmbPrefijo.Text, telefonoBox, out telefono);
            esCorrecto &= FuncionesInterfaz.ValidarNombre(especialidadBox, out especialidad);
            esCorrecto &= FuncionesInterfaz.ValidarTarifaHora(tarifaHoraBox, out tarifaHora);

            telefonoCompleto = cmbPrefijo.Text + telefono;

            if (esCorrecto) // Si es correcto se crea.
            {
                Designer designer = new(nombre, dni, email, telefonoCompleto, especialidad, tarifaHora);

                // Aquí mostramos usamos una condición, para saber si se añade o no, porque ya existe.
                if (_listaProfesionales.AddProfesional(designer))
                {
                    MessageBox.Show("Profesional añadido correctamente.");
                }
                else
                {
                    MessageBox.Show("Ya existe un profesional con ese DNI.");
                }
            }
        }


        // Load del formulario.
        private void FormDesigner_Load(object sender, EventArgs e)
        {
            txtTarifaHora.Text = "0";
        }


        // Botones.
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
            cmbPrefijo.Text = null;
            txtTelefono.Text = null;
            txtEspecialidad.Text = null;
            txtTarifaHora.Text = "0";
            txtNombre.Focus();
        }
    }
}
