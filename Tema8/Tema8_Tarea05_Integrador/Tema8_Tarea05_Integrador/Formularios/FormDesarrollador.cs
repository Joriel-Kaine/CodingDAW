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
            // Declaración de variables con los datos de los cuadros de texto.
            string nombreBox = txtNombre.Text,
                   dniBox = txtDNI.Text,
                   emailBox = txtEmail.Text,
                   telefonoBox = txtTelefono.Text,
                   lenguajePrincipalBox = txtLenguajePrincipal.Text,
                   tarifaHoraBox = txtTarifaHora.Text;

            // Declaración de variables donde se guardarán los valores ya validados y convertidos.
            string nombre, dni, email, telefono, lenguajePrincipal;
            double tarifaHora;

            // Declaración del booleano que comprobará que los datos son correctos.
            bool esCorrecto = true;

            // Se comprueba si los datos con correctos (con AND).
            esCorrecto &= FuncionesInterfaz.ValidarTexto(nombreBox, out nombre);
            esCorrecto &= FuncionesInterfaz.ValidarDNI(dniBox, out dni);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(emailBox, out email);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(telefonoBox, out telefono);
            esCorrecto &= FuncionesInterfaz.ValidarTexto(lenguajePrincipalBox, out lenguajePrincipal);
            esCorrecto &= FuncionesInterfaz.ValidarDouble(tarifaHoraBox, out tarifaHora);

            if (esCorrecto)
            {
                Desarrollador desarrollador = new(nombre, dni, email, telefono, lenguajePrincipal, tarifaHora);

                _listaProfesionales.AddProfesional(desarrollador);
            }
        }

        private void FormDesarrollador_Load(object sender, EventArgs e)
        {
            txtTarifaHora.Text = "0";
        }

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
            txtTelefono.Text = null;
            txtLenguajePrincipal.Text = null;
            txtTarifaHora.Text = "0";
            txtNombre.Focus();
        }
    }
}
