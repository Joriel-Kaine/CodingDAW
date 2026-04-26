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
    public partial class FormDesarrollador : Form
    {
        // Campos privados.
        private ListaProfesionales _listaProfesionales;


        // Constructor con parámetros de entrada.
        public FormDesarrollador(ListaProfesionales listaProfesionales)
        {
            InitializeComponent();
            this._listaProfesionales = listaProfesionales;
        }


        // Métodos.
        private void AddDesarrollador()
        {
            string nombreBox = txtNombre.Text,
                   dniBox = txtDNI.Text,
                   emailBox = txtEmail.Text,
                   telefonoBox = txtTelefono.Text,
                   lenguajePrincipalBox = txtLenguajePrincipal.Text,
                   tarifaHoraBox = txtTarifaHora.Text;

            string nombre, dni, email, telefono, lenguajePrincipal, telefonoCompleto;
            double tarifaHora;

            bool esCorrecto = true;

            esCorrecto &= FuncionesInterfaz.ValidarNombre(nombreBox, out nombre);
            esCorrecto &= FuncionesInterfaz.ValidarDNI(dniBox, out dni);
            esCorrecto &= FuncionesInterfaz.ValidarEmail(emailBox, out email);
            esCorrecto &= FuncionesInterfaz.ValidarTelefono(cmbPrefijo.Text, telefonoBox, out telefono);
            esCorrecto &= FuncionesInterfaz.ValidarNombre(lenguajePrincipalBox, out lenguajePrincipal);
            esCorrecto &= FuncionesInterfaz.ValidarTarifaHora(tarifaHoraBox, out tarifaHora);

            telefonoCompleto = cmbPrefijo.Text + telefono;

            if (esCorrecto)
            {
                Desarrollador desarrollador = new(nombre, dni, email, telefonoCompleto, lenguajePrincipal, tarifaHora);

                if (_listaProfesionales.AddProfesional(desarrollador))
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
        private void FormDesarrollador_Load(object sender, EventArgs e)
        {
            txtTarifaHora.Text = "0";
        }


        // Botones.
        private void btnAddDesarrollador_Click(object sender, EventArgs e)
        {
            this.AddDesarrollador();
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
            txtLenguajePrincipal.Text = null;
            txtTarifaHora.Text = "0";
            txtNombre.Focus();
        }
    }
}
