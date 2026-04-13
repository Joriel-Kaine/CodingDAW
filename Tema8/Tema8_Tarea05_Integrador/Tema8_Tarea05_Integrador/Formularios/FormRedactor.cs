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
            // Declaración de variables con los datos de los cuadros de texto.
            string nombreBox = txtNombre.Text,
                   dniBox = txtDNI.Text,
                   telefonoBox = txtTelefono.Text,
                   tematicaPrincipalBox = txtTematicaPrincipal.Text,
                   precioPorPalabraBox = txtPrecioPorPalabra.Text;

            // Declaración de variables donde se guardarán los valores ya validados y convertidos.
            string nombre, dni, telefono, tematicaPrincipal;
            double precioPorPalabra;

            // Declaración del booleano que comprobará que los datos son correctos.
            bool esCorrecto = true;

            // Se comprueba si los datos con correctos (con AND).
            esCorrecto &= FuncionesInterfaz.ValidarTexto(nombreBox, out nombre);
            esCorrecto &= FuncionesInterfaz.ValidarDNI(dniBox, out dni);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(telefonoBox, out telefono);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(tematicaPrincipalBox, out tematicaPrincipal);
            esCorrecto &= FuncionesInterfaz.ValidarDouble(precioPorPalabraBox, out precioPorPalabra);

            if (esCorrecto)
            {
                Redactor redactor = new(nombre, dni, telefono, tematicaPrincipal, precioPorPalabra);

                _listaProfesionales.AddProfesional(redactor);
            }
        }


        // Botones.
        private void FormRedactor_Load(object sender, EventArgs e)
        {
            txtPrecioPorPalabra.Text = "0";
        }

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
            txtTelefono.Text = null;
            txtTematicaPrincipal.Text = null;
            txtPrecioPorPalabra.Text = "0";
            txtNombre.Focus();
        }
    }
}
