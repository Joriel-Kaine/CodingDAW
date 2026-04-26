using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema8_Tarea05_Integrador.Interfaz;
using Tema8_Tarea05_Integrador.Profesionales;

namespace Tema8_Tarea05_Integrador
{
    public partial class FormRedactor : Form
    {
        // Campos privados.
        private ListaProfesionales _listaProfesionales;


        // Constructor con parámetros de entrada.
        public FormRedactor(ListaProfesionales listaProfesionales)
        {
            InitializeComponent();
            this._listaProfesionales = listaProfesionales;
        }


        // Métodos.
        private void AddRedactor()
        {
            string nombreBox = txtNombre.Text,
                   dniBox = txtDNI.Text,
                   emailBox = txtEmail.Text,
                   telefonoBox = txtTelefono.Text,
                   tematicaPrincipalBox = txtTematicaPrincipal.Text,
                   precioPorPalabraBox = txtPrecioPorPalabra.Text;

            string nombre, dni, email, telefono, tematicaPrincipal, telefonoCompleto;
            double precioPorPalabra;

            bool esCorrecto = true;

            esCorrecto &= FuncionesInterfaz.ValidarNombre(nombreBox, out nombre);
            esCorrecto &= FuncionesInterfaz.ValidarDNI(dniBox, out dni);
            esCorrecto &= FuncionesInterfaz.ValidarEmail(emailBox, out email);
            esCorrecto &= FuncionesInterfaz.ValidarTelefono(cmbPrefijo.Text, telefonoBox, out telefono);
            esCorrecto &= FuncionesInterfaz.ValidarNombre(tematicaPrincipalBox, out tematicaPrincipal);
            esCorrecto &= FuncionesInterfaz.ValidarPrecioPalabras(precioPorPalabraBox, out precioPorPalabra);

            telefonoCompleto = cmbPrefijo.Text + telefono;

            if (esCorrecto)
            {
                Redactor redactor = new(nombre, dni, email, telefonoCompleto, tematicaPrincipal, precioPorPalabra);

                if (_listaProfesionales.AddProfesional(redactor))
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
        private void FormRedactor_Load(object sender, EventArgs e)
        {
            txtPrecioPorPalabra.Text = "0";
        }


        // Botones.
        private void btnAddRedactor_Click(object sender, EventArgs e)
        {
            this.AddRedactor();
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
            txtTematicaPrincipal.Text = null;
            txtPrecioPorPalabra.Text = "0";
            txtNombre.Focus();
        }
    }
}
